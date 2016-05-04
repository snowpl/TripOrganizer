using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TripOrganization.Startup))]
namespace TripOrganization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
