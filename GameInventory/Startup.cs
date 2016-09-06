using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameInventory.Startup))]
namespace GameInventory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
