using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMovie.Startup))]
namespace MVCMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
