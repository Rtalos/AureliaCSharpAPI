using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Microsoft.Practices.Unity;
using BackendAPI.Repositories;
using Owin;

[assembly: OwinStartup(typeof(FrontendAPI.Startup))]

namespace FrontendAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
