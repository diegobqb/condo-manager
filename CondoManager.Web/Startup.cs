using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CondoManager.Web.Startup))]
namespace CondoManager.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
