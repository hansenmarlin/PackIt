using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PackIt.Startup))]
namespace PackIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
