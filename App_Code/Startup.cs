using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mainapp.Startup))]
namespace mainapp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
