using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMonitoring.Startup))]
namespace TestMonitoring
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //This is updated new change
            ConfigureAuth(app);
        }
    }
}
