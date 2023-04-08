using Core.Abstracts.Services.Data;
using Core.Abstracts.Services.Game;
using Microsoft.Extensions.DependencyInjection;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UI.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IArticleService, ArticleService>();
            services.AddSingleton<IGameService, GameService>();
            
            var serviceProvider = services.BuildServiceProvider();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            DependencyResolver.SetResolver(new DIResolver(serviceProvider));

        }
    }
    public class DIResolver : IDependencyResolver
    {
        private readonly IServiceProvider _provider;
        public DIResolver(IServiceProvider provider)
        {
            _provider = provider;
        }

        public object GetService(Type serviceType)
        {
            return _provider.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _provider.GetServices(serviceType);
        }
    }
}
