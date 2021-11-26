using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoControlAsistencia.Startup))]
namespace ProyectoControlAsistencia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
