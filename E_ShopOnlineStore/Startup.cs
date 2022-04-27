using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_ShopOnlineStore.Startup))]
namespace E_ShopOnlineStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
