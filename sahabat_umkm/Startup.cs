using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace sahabat_umkm {
  public class Startup {
    public Startup(IHostingEnvironment env) {
      var builder = new ConfigurationBuilder()
      .SetBasePath(env.ContentRootPath)
      .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
      .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
      .AddEnvironmentVariables();
      Configuration = builder.Build();

      AppCoreGlobal.BASE_URL = env.ContentRootPath;
      DbInitializer.Initialize();
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services) {
      services.AddMvc();
      // Include this after .AddMvc under ConfigureServices in Startup.cs
      services.Configure<RazorViewEngineOptions>(options => {
        options.ViewLocationExpanders.Add(new FeaturesViewLocationExpander());
      });

      services.AddDbContext<sahabat_umkm.m_news>(options => options.UseMySql(AppCoreGlobal.get_connection_string("Access", "MySQL")));

      services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); //get HTTPCONTEXT

      //new core 2.0 session handling is different from v1.1, using below code
      services
        .AddAuthentication(o => {
          o.DefaultScheme = "GLSCookieInstance";
          o.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
          o.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
          o.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        })
        .AddCookie(o => {
          o.LoginPath = new PathString("/Auth");
          o.AccessDeniedPath = new PathString("/Auth/Forbidden/");
          o.ExpireTimeSpan = TimeSpan.FromMinutes(AppCoreGlobal.get_session_timeout());
        }
      );

      services.Configure<IISOptions>(options => {
        options.ForwardClientCertificate = true; //IIS cannot access kestrel session claims by default, this code made it possible.
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
      if (env.IsDevelopment()) {
        app.UseDeveloperExceptionPage();
        app.UseBrowserLink();
      }
      else {
        app.UseExceptionHandler("/Home/Error");
      }

      app.UseStaticFiles();



      app.UseMvc(routes => {
        routes.MapRoute(
            name: "default",
            template: "{controller=Home}/{action=Index}/{id?}");
      });
    }
  }
}
