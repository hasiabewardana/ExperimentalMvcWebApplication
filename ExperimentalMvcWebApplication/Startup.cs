using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExperimentalMvcWebApplication.Startup))]
namespace ExperimentalMvcWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
