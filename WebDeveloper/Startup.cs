using LightInject;
using Microsoft.Owin;
using Owin;
using System.Reflection;
using WebDeveloper.Model;
using WebDeveloperDataAccess;

//[assembly: OwinStartupAttribute(typeof(WebDeveloper.Startup))]
namespace WebDeveloper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            var container = new ServiceContainer();
            //container.Register<IDataAccess<Client>, ClientData>();
            container.RegisterAssembly(Assembly.GetExecutingAssembly());
            container.RegisterAssembly("WebDeveloper.*.dll");
            container.RegisterAssembly("WebDeveloperDataAccess*.dll");
            //WebDeveloperDataAccess
            container.RegisterControllers();
            container.EnableMvc();
        }


    }
}
