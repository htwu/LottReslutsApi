using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.WebApi;
using LottResultsApi.IRepositories;
using LottResultsApi.IServices;
using LottResultsApi.Repositories;
using LottResultsApi.Services;

namespace LottResultsApi
{
    public class AutofacBoot
    {
        private static void SetupResolveRules(ContainerBuilder builder)
        {
//            var iRepository = Assembly.Load("LottResultApi");
//            var repository = Assembly.Load("LottResultApi");
//
//            builder.RegisterAssemblyTypes(iRepository, repository)
//                .Where(t => t.Name.EndsWith("Repository"))
//                .AsImplementedInterfaces();

            builder.RegisterType<LottResultRepository>().As<ILottResultRepository>();
            builder.RegisterType<LottResultService>().As<ILottResultService>();
        }

        public static void Init()
        {
            var builder = new ContainerBuilder();
            HttpConfiguration config = GlobalConfiguration.Configuration;
            SetupResolveRules(builder);

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();

            var container = builder.Build();
            
            config.DependencyResolver =  new AutofacWebApiDependencyResolver(container);
        }
    }
}