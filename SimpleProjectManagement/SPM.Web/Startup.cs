using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SPM.Web.Startup))]
namespace SPM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
