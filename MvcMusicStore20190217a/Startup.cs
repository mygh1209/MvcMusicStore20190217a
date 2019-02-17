using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMusicStore20190217a.Startup))]
namespace MvcMusicStore20190217a
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
