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

            builder
                .Register(r => new SchoolContext("server=localhost;database=dbcontoso;uid=root;pwd=root"))
                .As<DbContext>();

            builder
                .RegisterGeneric(typeof (Repository<>))
                .As(typeof (IRepository<>));

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