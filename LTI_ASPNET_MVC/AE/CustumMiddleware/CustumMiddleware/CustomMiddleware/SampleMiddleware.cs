using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustumMiddleware.CustomMiddleware
{
    public class SampleMiddleware
    {
        
        public SampleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public RequestDelegate _next { get; }

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync("<p> I am RequestHandler from Sample Middleware</p>");
            await _next.Invoke(context);
            await context.Response.WriteAsync("<p> I am ResponsetHandler from Sample Middleware</p>");
        }

        //public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        //{
        //    await context.Response.WriteAsync("<p> I am RequestHandler from Sample Middleware</p>");
        //    await next.Invoke(context);
        //    await context.Response.WriteAsync("<p> I am ResponsetHandler from Sample Middleware</p>");
        //}
    }

    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseSample(this IApplicationBuilder app)
        {
           return  app.UseMiddleware<SampleMiddleware>();

        }


    }
}
