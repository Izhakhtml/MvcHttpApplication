using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcHttpApplication.Startup))]
namespace MvcHttpApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
