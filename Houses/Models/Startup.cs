using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Houses.Startup))]
namespace Houses
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
