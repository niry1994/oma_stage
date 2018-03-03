using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAutomatisé.Startup))]
namespace TestAutomatisé
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
