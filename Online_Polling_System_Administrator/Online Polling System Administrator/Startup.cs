using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_Polling_System_Administrator.Startup))]
namespace Online_Polling_System_Administrator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
            
        }
    }
}
