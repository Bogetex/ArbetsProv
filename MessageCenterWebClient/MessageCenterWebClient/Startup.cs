using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MessageCenterWebClient.Startup))]
namespace MessageCenterWebClient
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
