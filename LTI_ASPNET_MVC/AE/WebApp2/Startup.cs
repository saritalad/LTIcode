using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //DefaultFilesOptions defaultFiles = new DefaultFilesOptions();
            //defaultFiles.DefaultFileNames.Clear();
            //defaultFiles.DefaultFileNames.Add("Home.html");
            //app.UseDefaultFiles(defaultFiles);
            app.UseStaticFiles();

            app.Use(async (context, Next) =>
            {
                await context.Response.WriteAsync("This is Ist Request \n");

                await Next();
                await context.Response.WriteAsync("This is Ist Response \n");

            });
            app.Use(async (context, Next) =>
            {
                await context.Response.WriteAsync("This is IIst Request  \n config:"+Configuration["MyKey"]+"\n");

                await Next();
                await context.Response.WriteAsync("this is IIst Response \n");

            });

            app.Use(async(context, Next)=>
            {

                await context.Response.WriteAsync("\n This request is Third Middleware ");
                await Next();
                await context.Response.WriteAsync("\n This is Response from third Middlware ");
            }   
                     );
            app.Run(async(context)=> { await context.Response.WriteAsync("\n This is Terminal Middleware"); });
        }
    }
}
