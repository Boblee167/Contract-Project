using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContractManager.Startup))]
namespace ContractManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
