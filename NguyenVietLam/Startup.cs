using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenVietLam.Startup))]
namespace NguyenVietLam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
