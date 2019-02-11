using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using MySql.Data.MySqlClient;
namespace mysqlAndroid
{
    public static class WebApiConfig
    {

        public static MySqlConnection con() {
            string con_string = "server=localhost;port=3306;database=movies;username=root;password=''";
            MySqlConnection con = new MySqlConnection(con_string);
            return con;

        }
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.EnableCors();
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
