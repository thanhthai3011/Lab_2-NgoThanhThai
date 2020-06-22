using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VnExpress_NgoThanhThai_Lab1.Startup))]
namespace VnExpress_NgoThanhThai_Lab1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
