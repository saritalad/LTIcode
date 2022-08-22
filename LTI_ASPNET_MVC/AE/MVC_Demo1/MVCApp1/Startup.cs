using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp1
{
}
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        });
        app.UseEndpoints(endpoints =>
        {// Attribute Contraints  alpha for  aphabet 
            endpoints.MapGet("/hello/{name:alpha}", async context =>
            {
                var name = context.Request.RouteValues["name"];
                await context.Response.WriteAsync($"Hello {name}!");
            });
        });



        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
              name: "default",
              pattern: "{action=Index}/{controller=Home}/{id?}");


        });

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
              name: "employee",
              pattern: "{controller=Employees}/{action=Index}/{id?}");


        });

    }
}