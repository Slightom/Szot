using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Szot.Startup))]
namespace Szot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
