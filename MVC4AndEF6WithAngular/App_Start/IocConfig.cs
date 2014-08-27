using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using MVC4AndEF6WithAngular.Data.Contexts;
using MVC4AndEF6WithAngular.Data.Services;
using System.Data.Entity;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace MVC4AndEF6WithAngular
{
    public class IocConfig
    {

        public static void RegisterIoC()
        {
            var builder = new ContainerBuilder();

            //builder
            //    .RegisterType<ConfigurationReader>()
            //    .As<IConfigurationReader>();

            builder
                .RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();

            builder
                .RegisterAssemblyTypes(typeof (SchoolContext).Assembly)
                .AsImplementedInterfaces();

            var connectionString =
                System.Configuration.ConfigurationManager.ConnectionStrings["SchoolContext"].ConnectionString;

            builder
                .Register(r => new SchoolContext(connectionString))
                .As<ISchoolContext>();

            builder
                .RegisterControllers(Assembly.GetExecutingAssembly());

            builder
                .RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}