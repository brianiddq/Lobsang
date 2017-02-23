using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lobsang.Startup))]
namespace Lobsang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
