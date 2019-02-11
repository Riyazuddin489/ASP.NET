using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using mysqlAndroid.Models;
using System.Web.Http.Cors;
namespace mysqlAndroid.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MoviesController : ApiController
    {
        MySqlConnection con;
        MySqlCommand query;

        public MoviesController() {
            con= WebApiConfig.con();
             query = con.CreateCommand();
            con.Open();

        }

        public List<result> GetMovies() {

            query.CommandText = "select * from Movie";
            var result = new List<result>();
            MySqlDataReader fetchData = query.ExecuteReader();
            while (fetchData.Read()) {

                //  result.Add(new result(int.Parse(fetchData["id"].ToString()), fetchData["name"].ToString(), fetchData["description"].ToString() , int.Parse(fetchData["Rating"].ToString()), fetchData["Categorie"].ToString(), fetchData["studio"].ToString(), fetchData["img"].ToString(), DateTime.Parse(fetchData["dateReleased"].ToString())));
                result.Add(
                   new result() {           //creting object of result and assigning values of resuult properties withput constructor
                       id = int.Parse(fetchData["id"].ToString()),
                       name = fetchData["name"].ToString(),
                       description = fetchData["description"].ToString(),
                       Rating = int.Parse(fetchData["Rating"].ToString()),
                       Categorie = fetchData["Categorie"].ToString(),
                       studio = fetchData["studio"].ToString(),
                       img = fetchData["img"].ToString(),
                       dateReleased = DateTime.Parse(fetchData["dateReleased"].ToString())        

                       }   );//add closed
                   }//while closed
            return result;
        }


        public result GetMovies(int id) {
            query.CommandText = "select * from movie where id=@id";
            query.Parameters.AddWithValue("@id", id);
            MySqlDataReader fetchData = query.ExecuteReader();
            result SingleResult;
            if (fetchData.Read())
            {
                SingleResult = new result()
                {
                    id = int.Parse(fetchData["id"].ToString()),
                    name = fetchData["name"].ToString(),
                    description = fetchData["description"].ToString(),
                    Rating = int.Parse(fetchData["Rating"].ToString()),
                    Categorie = fetchData["Categorie"].ToString(),
                    studio = fetchData["studio"].ToString(),
                    img = fetchData["img"].ToString(),
                    dateReleased = DateTime.Parse(fetchData["dateReleased"].ToString())

                };
                return SingleResult;
            }
            else return null;
        }


        public IHttpActionResult PostMovies(result Result) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            query.CommandText = "insert into movie (name, description,Rating, Categorie, studio, img,dateReleased)values(@v1,@v2,@v3,@v4,@v5,@v6,@v7)";
            query.Parameters.AddWithValue("@v1",Result.name);
            query.Parameters.AddWithValue("@v2",Result.description);
            query.Parameters.AddWithValue("@v3", Result.Rating);
            query.Parameters.AddWithValue("@v4",Result.Categorie);
            query.Parameters.AddWithValue("@v5",Result.studio);
            query.Parameters.AddWithValue("@v6",Result.img);
            query.Parameters.AddWithValue("@v7",Result.dateReleased);
          var fetchResult=  query.ExecuteNonQueryAsync();

            if (fetchResult.Result>0)
            {
               return CreatedAtRoute("DefaultApi", new { id = Result.id }, Result);
                //return route of newly created object with status of created
            }
            else
            { return BadRequest(ModelState); }


        }

        public IHttpActionResult PutMovies(int id, result Result) {


            query.CommandText = "update  movie  set name=@v1, description=@v2,Rating=@v3, Categorie=@v4, studio=@v5, img=@v6,dateReleased=@v7 where id=@id";
            query.Parameters.AddWithValue("@v1", Result.name);
            query.Parameters.AddWithValue("@v2", Result.description);
            query.Parameters.AddWithValue("@v3", Result.Rating);
            query.Parameters.AddWithValue("@v4", Result.Categorie);
            query.Parameters.AddWithValue("@v5", Result.studio);
            query.Parameters.AddWithValue("@v6", Result.img);
            query.Parameters.AddWithValue("@v7", Result.dateReleased);
            query.Parameters.AddWithValue("@id",id);

            var fetchResult = query.ExecuteNonQueryAsync();

            if (fetchResult.Result > 0)
            {
                return StatusCode(HttpStatusCode.Accepted);
            }
            else
            {
                return BadRequest(ModelState);
            }
           
        }


        public IHttpActionResult DeleteMovies(int id)
        {


            query.CommandText = "delete from  movie  where id=@id";
            query.Parameters.AddWithValue("@id", id);

            var fetchResult = query.ExecuteNonQueryAsync();

            if (fetchResult.Result > 0)
            {
                return StatusCode(HttpStatusCode.Found);
            }
            else
            {
                return StatusCode(HttpStatusCode.NotFound);
            }

        }


        protected override void Dispose(bool disposing)
        {
            con.Close();
            query.Dispose();
        }
    }
}
