using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using mysqlAndroid.Controllers;
namespace mysqlAndroid.Models
{
    public class result
    {
       
        public int  id { get; set; }
        public string name  { get; set; }

      //  [Required]
        public string description { get; set; }
        public int Rating { get; set; }
        public string Categorie { get; set; }
        public string studio { get; set; }
        public string  img{ get; set; }
        public DateTime dateReleased { get; set; }

        //public result(int id,string name,string description,int rating,string categorie,string studio,string img,datetime datereleased) {

        //    this.id = id;
        //    this.name = name;
        //    this.description = description;
        //    this.rating = rating;
        //    this.categorie = categorie;
        //    this.studio = studio;

        //    this.img = img;
        //    this.datereleased = datereleased;




        //}
       
    }
}