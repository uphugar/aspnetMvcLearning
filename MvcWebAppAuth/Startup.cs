using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWebAppAuth.Startup))]
namespace MvcWebAppAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
