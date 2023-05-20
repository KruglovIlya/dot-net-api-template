using ASP.NET_API.Exceptions;

namespace ASP.NET_API.Helpers
{
    public class MiddlewareExceptions
    {
        private readonly RequestDelegate _next;

        public MiddlewareExceptions(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            try
            {
                await _next(context);
            }
            catch (HttpException ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, HttpException httpException)
        {
            var code = httpException.Code;
            var result = string.Empty;

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = code;

            if (result == string.Empty)
            {
                result = System.Text.Json.JsonSerializer.Serialize(new { error = httpException.Message });
            }

            return context.Response.WriteAsync(result);
        }
    }
}
