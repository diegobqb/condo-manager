using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CondoManager.Startup))]
namespace CondoManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
