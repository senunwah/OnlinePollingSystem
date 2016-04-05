using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_Polling_System_Client.Startup))]
namespace Online_Polling_System_Client
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
