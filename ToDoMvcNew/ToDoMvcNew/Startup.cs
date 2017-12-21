using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoMvcNew.Startup))]
namespace ToDoMvcNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
