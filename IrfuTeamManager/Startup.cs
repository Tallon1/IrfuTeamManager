using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IrfuTeamManager.Startup))]
namespace IrfuTeamManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
