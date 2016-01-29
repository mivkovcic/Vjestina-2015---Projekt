using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportEvents.Startup))]
namespace SportEvents
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
