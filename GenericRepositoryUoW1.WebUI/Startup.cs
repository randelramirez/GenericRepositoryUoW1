using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GenericRepositoryUoW1.WebUI.Startup))]
namespace GenericRepositoryUoW1.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
