﻿using englishProject.Infrastructure.Users;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Facebook;
using Microsoft.Owin.Security.Google;
using Owin;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Web.config", Watch = true)]

namespace englishProject
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<UserAppDbContext>(() => new UserAppDbContext());
            app.CreatePerOwinContext<UserAppManager>(UserAppManager.Create);
            app.CreatePerOwinContext<RoleAppManager>(RoleAppManager.Create);

            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Home/Index"),
                LogoutPath = new PathString("/Home/Index"),
                CookieName = "wordboxes",
                ExpireTimeSpan = TimeSpan.FromDays(120),
            });
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            #region GoogleLogin

            GoogleOAuth2AuthenticationOptions g = new GoogleOAuth2AuthenticationOptions
            {
                ClientId = "40850217574-jucv506k8kd4kqaopigi68p0umurr9mi.apps.googleusercontent.com",
                ClientSecret = "aYx3KnsZM_m_voAUtJFaypsy",
                CallbackPath = new PathString("/User/GoogleLogin"),

                SignInAsAuthenticationType = DefaultAuthenticationTypes.ExternalCookie,
            };
            app.UseGoogleAuthentication(g);

            #endregion GoogleLogin

            #region FacebookLogin

            FacebookAuthenticationOptions f = new FacebookAuthenticationOptions
            {
                AppId = "1548784555450367",
                AppSecret = "8882f3a05815afd5cfd5ac2ce09c9aa9",
                Provider = new FacebookAuthenticationProvider()
                {
                    OnAuthenticated = context =>
                    {
                        context.Identity.AddClaim(new System.Security.Claims.Claim("FacebookAccessToken",
                            context.AccessToken));
                        return Task.FromResult(true);
                    }
                },
                SignInAsAuthenticationType = DefaultAuthenticationTypes.ExternalCookie,
            };
            f.Scope.Add("email");
            // f.Scope.Add("email");
            app.UseFacebookAuthentication(f);

            #endregion FacebookLogin
        }
    }
}