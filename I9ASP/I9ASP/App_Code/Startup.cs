using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(I9ASP.Startup))]
namespace I9ASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
