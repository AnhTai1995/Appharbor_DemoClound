using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Appharbor_SQL.Startup))]
namespace Appharbor_SQL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
