using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityCodeFirst.Startup))]
namespace EntityCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
