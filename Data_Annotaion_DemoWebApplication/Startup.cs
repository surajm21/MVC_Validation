using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Data_Annotaion_DemoWebApplication.Startup))]
namespace Data_Annotaion_DemoWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
