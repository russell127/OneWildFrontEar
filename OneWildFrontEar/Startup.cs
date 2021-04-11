using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneWildFrontEar.Startup))]
namespace OneWildFrontEar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
