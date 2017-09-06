using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntegracaoEmail.Startup))]
namespace IntegracaoEmail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
