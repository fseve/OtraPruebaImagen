using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OtraPruebaImagen.Startup))]
namespace OtraPruebaImagen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
