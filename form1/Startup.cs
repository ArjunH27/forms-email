using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(form1.Startup))]
namespace form1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
