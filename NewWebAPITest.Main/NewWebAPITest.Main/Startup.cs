using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewWebAPITest.Main.Startup))]
namespace NewWebAPITest.Main
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
