using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMonitoring.Startup))]
namespace TestMonitoring
{
    public partial class Startup
    {
        
        //this is changed from github web
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
