using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.OAuth;
using System;
using Accounts.Providers;

[assembly: OwinStartup(typeof(Accounts.Startup))]
namespace Accounts
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            app.UseOAuthAuthorizationServer(new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(60),
                Provider = new CustomOAuthAuthorizationServerProvider(),
                #if DEBUG
                AllowInsecureHttp = true
                #endif
            });

        }
    }
}