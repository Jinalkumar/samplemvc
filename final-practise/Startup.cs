using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(final_practise.Startup))]
namespace final_practise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
