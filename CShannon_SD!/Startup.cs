using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CShannon_SD_.Startup))]
namespace CShannon_SD_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
