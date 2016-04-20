using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GMTSongbook.Startup))]
namespace GMTSongbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
