using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MariyanProject.Startup))]
namespace MariyanProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
