using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BandAngluar.Startup))]
namespace BandAngluar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
