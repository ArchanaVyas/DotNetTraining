using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace NetTrainingJan.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware1
    {
        private readonly RequestDelegate _next;

        public Middleware1(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine("Middleware Training");
            Console.WriteLine("Hello Archana Mid1 sending request");
            await _next(httpContext);
            Console.WriteLine("Mid1 response");

        }
    }

    public class Middleware2
    {
        private readonly RequestDelegate _next;

        public Middleware2(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine("Middleware2");
            Console.WriteLine("Mid2 sending request");
            await _next(httpContext);
            Console.WriteLine("Mid2 response");

        }
    }


    // Extension method used to add the middleware to the HTTP request pipeline.


    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMiddlewares(this IApplicationBuilder app)
        {
            return app
                .UseMiddleware<Middleware1>()
                .UseMiddleware<Middleware2>();
        }
    }

}
