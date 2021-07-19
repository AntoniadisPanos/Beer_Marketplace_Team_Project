using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Omadiko.Database;
using Owin;
using System.Web.Services.Description;

[assembly: OwinStartupAttribute(typeof(Omadiko.WebApp.Startup))]
namespace Omadiko.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
       
    }
   
}
