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

namespace WebApp1
{
    public class Startup
    {
       
        public IConfiguration _config { get; }
        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

      

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

            //FileServerOptions fileServerOptions = new FileServerOptions();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("Home.html");

            // this works as terminal midlleware
              app.UseFileServer();
              app.UseStaticFiles();
                app.UseRouting();
            //app.Use(async(context, Next) => { await context.Response.WriteAsync("<h1>This is First Middleware</h1><br>");


            //    await Next();
            //    await context.Response.WriteAsync("This is Response  from 1st  MiddleWare");
            //});
            app.Use(async (context, Next) =>
            {

                await context.Response.WriteAsync("<br>This is second Middleware Request");
                await Next();
                await context.Response.WriteAsync("<br>This is Response  from 2st  MiddleWare");
            });
            //            app.Run(async (context) =>
            //{
            //                //  await context.Response.WriteAsync("<h1>Welcome</h1>"+"<br>"+System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            //                await context.Response.WriteAsync("<Br>" + _config["myKey"]);
            //});


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Employees}/{action=Index}/{id?}");
            });


        }
    }
}
//Code Explanation
//We are using Run() method to add middleware to our application's request processing pipeline
//If you hover the mouse over the Run() method, from the intellisense you can see that this Run() method is implemented as an extension method of IApplicationBuilder interface. This is the reason we are able to invoke this Run() method on IApplicationBuilder object app.
//The parameter that we are passing to the Run() method is a RequestDelegate which we can see from the intellisense.
//RequestDelegate is a delegate that has HttpContext object as a parameter. 
//It is through this HttpContext object, the middleware gains access to both the incoming http request and outgoing http response.
//At the moment, we are passing request delegate inline as an anonymous method using a lambda
//So here are the 3 very important points to keep in mind regarding the request processing pipeline
//Everything that happens before the next() method is invoked in each of the middleware components, happen as the request travels from middleware to middleware through the pipeline and this is represented by the incoming arrow.
//When a middleware handles the request and produces response, the request processing pipeline starts to reverse.
//Everything that happens after the next() method is invoked in a middleware component, happens as the response travels from middleware to middleware through the pipeline and this is represented by the outgoing arrow.