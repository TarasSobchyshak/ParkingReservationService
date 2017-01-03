using Microsoft.Owin;
using Owin;


[assembly: OwinStartup(typeof(PRS.WebApi.Startup))]

namespace PRS.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}