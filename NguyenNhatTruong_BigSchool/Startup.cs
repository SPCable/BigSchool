using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenNhatTruong_BigSchool.Startup))]
namespace NguyenNhatTruong_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
