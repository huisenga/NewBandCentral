using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BandCentral.Startup))]
namespace BandCentral
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
