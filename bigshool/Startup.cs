using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bigshool.Startup))]
namespace bigshool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
