using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(taxes.Startup))]
namespace taxes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
