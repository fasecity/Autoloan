using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Autoloan.Startup))]
namespace Autoloan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
