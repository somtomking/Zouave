using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zouave.Admin.Startup))]
namespace Zouave.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
