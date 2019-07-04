using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnonseWeb.Startup))]
namespace AnonseWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
