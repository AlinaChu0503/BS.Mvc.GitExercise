using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BS.Mvc.GitExercise.Startup))]
namespace BS.Mvc.GitExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
