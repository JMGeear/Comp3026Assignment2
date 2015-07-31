using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comp3026Assignment2.Startup))]
namespace Comp3026Assignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
