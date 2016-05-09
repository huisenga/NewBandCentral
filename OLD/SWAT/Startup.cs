using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SWAT.Startup))]
namespace SWAT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
