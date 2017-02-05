using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVClab3.Startup))]
namespace MVClab3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
