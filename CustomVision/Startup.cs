using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomVision.Startup))]
namespace CustomVision
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
