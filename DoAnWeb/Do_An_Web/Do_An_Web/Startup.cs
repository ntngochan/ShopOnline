﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Do_An_Web.Startup))]
namespace Do_An_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
