using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Headers;

namespace MovieAPIDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            config.EnableCors();


            config.Routes.MapHttpRoute(
                "filterMovies", "api/Movies/filterMovie", new { Controller="Movies",action="filterMovie"}
                );

            config.Routes.MapHttpRoute(
                "PostMovie", "api/Movies/PostMovie", new { Controller = "Movies", action = "PostMovie" }
                );




            config.Routes.MapHttpRoute(
                "DescMovies", "api/Movies/DescMovie", new { Controller = "Movies", action = "DescMovie" }
                );
            config.Routes.MapHttpRoute(
                "GetMovie", "api/Movies/GetMovie", new { Controller = "Movies", action = "GetMovie" }
                );
            config.Routes.MapHttpRoute(
                "GetMovie2", "api/Movies/GetMovie/{id}", new { Controller = "Movies", action = "GetMovie" }, new { id=@"\d"}
                );





            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
