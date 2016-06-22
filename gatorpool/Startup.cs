using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gatorpool.Startup))]
namespace gatorpool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
