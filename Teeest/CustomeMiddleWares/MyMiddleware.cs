using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using System;
using System.Threading.Tasks;

namespace Middlewares.Teeest
{

    public class ErrorHandlerMiddleware
    {
        public class HttpStatusCodeException : Exception
        {
            public HttpStatusCode StatusCode { get; set; }

            public HttpStatusCodeException(HttpStatusCode statusCode)
            {
                StatusCode = statusCode;
            }
        }

        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                if(context.Response.StatusCode == 200)
                {
                    context.Response.StatusCode = 405;
                    

                }
                await _next(context);

            }
            catch (Exception exception)
            {
                context.Response.StatusCode = 405;
                context.Response.Headers.Clear();
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MyMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
