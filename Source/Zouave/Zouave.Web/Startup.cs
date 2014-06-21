using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zouave.Web.Startup))]
namespace Zouave.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
