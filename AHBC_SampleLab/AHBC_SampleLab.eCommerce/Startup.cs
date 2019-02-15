using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AHBC_SampleLab.eCommerce.Startup))]
namespace AHBC_SampleLab.eCommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
