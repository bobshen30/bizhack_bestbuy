using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bestbuy_case2.Startup))]
namespace Bestbuy_case2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
