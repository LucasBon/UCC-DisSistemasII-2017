using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaTurnosWeb.Startup))]
namespace SistemaTurnosWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
