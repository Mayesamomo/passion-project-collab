using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnimeMusic.Startup))]
namespace AnimeMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
