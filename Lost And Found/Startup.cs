using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lost_And_Found.Startup))]
namespace Lost_And_Found
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
