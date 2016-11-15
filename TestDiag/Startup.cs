using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestDiag.Startup))]
namespace TestDiag
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
