using System.Web.Http;
using LightInject;
using CorePracticeDemo.Repositories;
using CorePracticeDemo.Repositories.Interfaces;
using CorePracticeDemo.Data;
using CorePracticeDemo.App_Start;
using CorePracticeDemo.Services;
using System.Web;

namespace Tofi.Demo.Api
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            var container = new ServiceContainer();

            container.Register<DemoDataContext>(c => new DemoDataContext("connectionString"));
            container.Register<IUserRepository, UserRepository>();
            container.Register<UserService, UserService>();

            container.RegisterApiControllers();
            container.EnableWebApi(GlobalConfiguration.Configuration);
        }
    }
}
