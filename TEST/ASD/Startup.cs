using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASD.Startup))]
namespace ASD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
