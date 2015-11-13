using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SPE.Store.Web.Startup))]
namespace SPE.Store.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
