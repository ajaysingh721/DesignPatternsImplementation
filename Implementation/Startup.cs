using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Implementation.Startup))]
namespace Implementation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
