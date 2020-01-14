using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApi_Test_CRM_Dummy
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Configuracion de log4net
            XmlConfigurator.Configure();
            // Configuración y servicios de API web
            config.EnableCors();
            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
