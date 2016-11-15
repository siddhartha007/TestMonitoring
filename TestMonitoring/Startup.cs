using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMonitoring.Startup))]
namespace TestMonitoring
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
