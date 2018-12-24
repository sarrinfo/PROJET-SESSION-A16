
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: Microsoft.Owin.OwinStartup(typeof(ProjetSessionCoursA15.App_Start.AuthConfig))]
namespace ProjetSessionCoursA15.App_Start
{
    public class AuthConfig
    {
        /*
        * ici on configure l'application pour:
        * utiliser un cookie pour garder l'info que l'utilisateur est authentifié
        * indiquer l'action vers laquelle est dirigé tout utilisateur non authentifié
        */
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new Microsoft.Owin.PathString("/Authentication/Login")
            });
        }
    }
}