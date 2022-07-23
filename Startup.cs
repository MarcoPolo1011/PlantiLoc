using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Progetto.Startup))]
namespace Progetto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
