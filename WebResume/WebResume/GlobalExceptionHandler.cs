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
      httpContext.Response.ContentType = "application/json";

      var contextFeature = httpContext.Features.Get<IExceptionHandlerFeature>();
      if (contextFeature is not null) 
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
          case PersonalInfoDeserializeException:
            httpContext.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            break;
          case ContactInfoDeserializeException:
            httpContext.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            break;
          case EducationDeserializeException:
            httpContext.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            break;
          case CourseDeserializeException:
            httpContext.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            break;
          case LanguageInfoDeserializeException:
            httpContext.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            break;
          case AdditionalInfoDeserializeException:
            httpContext.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
            break;
          case PhotoSizeException:
            httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            break;
          case CitizenshipIsEmptyException:
            httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            break;
          case BucketUndefinedException:
            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
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
