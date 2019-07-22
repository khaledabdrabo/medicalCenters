using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Medicalcenter.Startup))]
namespace Medicalcenter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
