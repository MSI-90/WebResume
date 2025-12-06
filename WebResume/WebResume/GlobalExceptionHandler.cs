using Entites.ErrorModel;
using Entites.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace WebResume
{
  public class GlobalExceptionHandler : IExceptionHandler
  {
    private readonly ILogger _logger;
    public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger) 
    {
      _logger = logger;
    }
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
      httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
      httpContext.Response.ContentType = "application/json";

      var contextFeature = httpContext.Features.Get<IExceptionHandlerFeature>();
      if (contextFeature != null) 
      {
        switch (contextFeature.Error)
        {
          case ResumeNotFoundException:
            httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            break;
          case TemplateNotFoundException:
            httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            break;
          case DesiredJobInfoDeserializeException:
            httpContext.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            break;
          case ExperienceDeserializeException:
            httpContext.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            break;
          case PhotoBigSizeException:
            httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            break;
          default: httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError; 
            break;
        }

        _logger.LogError($"Что-то пошло не так: {exception.Message}");
        await httpContext.Response.WriteAsync(new ErrorDetails()
        { 
          StatusCode = httpContext.Response.StatusCode,
          Message = exception.Message,
        }.ToString());
      }

      return true;
    }
  }
}
