using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MovieAPIDemo.Models;
using System.Web.Http.Cors;

namespace MovieAPIDemo.Controllers.api
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]


    public class MoviesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        //api/Movies/DescMovie
        [HttpGet]//return only list of name and description
        public List<descMovie> DescMovie() {
           var a= db.Movie.Select(c => new descMovie() { Name=c.Name, Description=c.Description }).ToList();
            return a  ;
        }


        //if filter data comes from formBody or by post()
        //api/Movies/filterMovie
        [HttpPost]
        public IQueryable<Movie> filterMovie(Movie movie)
        {

            var r = db.Movie.Include(c => c.Genre);

            if (movie.Rating != 0)
            r=    r.Where(c => c.Rating == movie.Rating);
            if (movie.Name != null)
              r=  r.Where(c => c.Name == movie.Name);
            if (movie.DateReleased != null)
                r=r.Where(c => c.DateReleased == movie.DateReleased);
            if (movie.Genre != null)
            {
                if (movie.Genre.Name != null)
                  r=  r.Where(c => c.Genre.Name == movie.Genre.Name);
            }
            if (movie.Description != null)
                r=r.Where(c => c.Description == movie.Description);
            if (movie.Genre_Id != 0)
               r= r.Where(c => c.Genre_Id == movie.Genre_Id);

            return r;

        }

        //api/Movies/GetMovie
        [HttpGet]
        public IQueryable<Movie> GetMovie()
        {
            return db.Movie.Include(c=>c.Genre);
        }

        //api/Movies/GetMovie/4
        [ResponseType(typeof(Movie))]
        [HttpGet]
        public IHttpActionResult GetMovie(int id)
        {
            Movie movie = db.Movie.Include(c => c.Genre).Where(c=>c.Id==id).SingleOrDefault();
            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        // PUT: api/Movies/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMovie(int id, Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            

            if (id != movie.Id)
            {
                return BadRequest();
            }

            db.Entry(movie).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        //api/Movies/PostMovie
        [ResponseType(typeof(Movie))]
        [HttpPost]
        public IHttpActionResult PostMovie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Movie.Add(movie);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = movie.Id }, movie);
        }

        // DELETE: api/Movies/5
        [ResponseType(typeof(Movie))]
        public IHttpActionResult DeleteMovie(int id)
        {
            Movie movie = db.Movie.Find(id);
            if (movie == null)
            {
                return NotFound();
            }

            db.Movie.Remove(movie);
            db.SaveChanges();

            return Ok(movie);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MovieExists(int id)
        {
            return db.Movie.Count(e => e.Id == id) > 0;
        }
    }
}