using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mainapp_adminsite.Startup))]
namespace mainapp_adminsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
