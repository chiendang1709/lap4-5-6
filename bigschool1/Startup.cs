using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bigschool1.Startup))]
namespace bigschool1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
