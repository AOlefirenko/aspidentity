using System;

[assembly: OwinStartup(typeof(OwinStartup))]
namespace NgPlaybook.Server.Startup
{

    public class OwinStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseOAuthAuthorizationServer(new MyOAuthOptions());
            app.UseJwtBearerAuthentication(new MyJwtOptions());
        }
    }
}