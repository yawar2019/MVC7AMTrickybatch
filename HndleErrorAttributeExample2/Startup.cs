using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HndleErrorAttributeExample2.Startup))]
namespace HndleErrorAttributeExample2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
