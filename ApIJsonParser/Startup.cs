using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApIJsonParser.Startup))]
namespace ApIJsonParser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
