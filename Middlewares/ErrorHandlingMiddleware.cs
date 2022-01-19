using System.ComponentModel.DataAnnotations;

namespace dotnet_api_error_handling_example.Middlewares
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, ILogger<ErrorHandlingMiddleware> _logger)
        {
            try
            {
                await _next(httpContext);
            }
            catch (ArgumentNullException e)
            {
                _logger.LogError(e.Message);
            }
            catch (ValidationException e)
            {
                _logger.LogError(e.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            
        }
    }
}
