using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATM_app.Startup))]
namespace ATM_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
