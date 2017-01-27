using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlashCards.Startup))]
namespace FlashCards
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
