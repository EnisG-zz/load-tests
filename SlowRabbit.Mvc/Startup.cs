using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SlowRabbit.Mvc.Startup))]
namespace SlowRabbit.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
