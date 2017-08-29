using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestSignOn.Startup))]
namespace TestSignOn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
