using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using Unity;
using admobsnews.cs;
using System.Web.Http.Cors;
using Unity.Lifetime;
using MicrosoftUnityDependencyInjectionApiDemo.implementation;
using MicrosoftUnityDependencyInjectionApiDemo.Interface;

namespace MicrosoftUnityDependencyInjectionApiDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));


            var container = new UnityContainer();
            container.RegisterType<IProductService, ProductService>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
             
            // Enabled cors 
            //Todo now cros is enable for all endpoint in production need to change to application site
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Setting the response format to json 
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.Remove(config.Formatters.XmlFormatter); 

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
