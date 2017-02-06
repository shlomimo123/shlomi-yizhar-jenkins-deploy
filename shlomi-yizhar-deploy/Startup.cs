using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shlomi_yizhar_deploy.Startup))]
namespace shlomi_yizhar_deploy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
