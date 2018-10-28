using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineStoreApp.Startup))]
namespace OnlineStoreApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
