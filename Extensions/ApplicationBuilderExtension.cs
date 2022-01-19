using dotnet_api_error_handling_example.Middlewares;

namespace dotnet_api_error_handling_example.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseErrorHandling(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlingMiddleware>();
        }
    }
}
