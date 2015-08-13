using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BilgeWater.Startup))]
namespace BilgeWater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
