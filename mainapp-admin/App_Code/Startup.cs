using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mainapp_admin.Startup))]
namespace mainapp_admin
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
