using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JSON_Payment_Portal.Startup))]
namespace JSON_Payment_Portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
