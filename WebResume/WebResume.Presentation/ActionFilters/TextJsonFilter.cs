using Entites.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Shared.DataTransferObjects;
using System.Runtime;
using System.Text.Json;

namespace WebResume.Presentation.ActionFilters
{
  public class TextJsonFilter : IActionFilter
  {
    public void OnActionExecuted(ActionExecutedContext context)
    {
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
      var resumeObj = context.ActionArguments["resumeForCreateDto"];
      if (resumeObj is not null)
      {
        var resumeData = (ResumeForCreationDto)resumeObj;
        var desiredJob = resumeData.DesiredJob;
        var exp = resumeData.Experience;
        var desiredJobCheckResult = CheckJobInfoAsValid(desiredJob);
        if (!desiredJobCheckResult)
          context.Result = new UnprocessableEntityObjectResult("DesiredJob data is invalid");

        var expirationCheckResult = CheckExperienceAsValid(exp);
        if (!expirationCheckResult)
          context.Result = new UnprocessableEntityObjectResult("Expiration data is invalid");
      }
    }

    private static bool CheckJobInfoAsValid(string? jobInfo)
    {
      if (string.IsNullOrEmpty(jobInfo) || string.IsNullOrWhiteSpace(jobInfo))
        return false;

      try
      {
        var job = JsonSerializer.Deserialize<DesiredJobInfoForCreationDto>(jobInfo);
        if (job is null) return false; 
        return true;
      } 
      catch 
      {
        return false;
      }
    }

    private static bool CheckExperienceAsValid(IEnumerable<string>? experience)
    {
      if (experience is null || !experience.Any())
        return false;

      foreach (var item in experience)
      {
        try
        {
          var exp = JsonSerializer.Deserialize<ExperienceForCreationDto>(item);
          if (exp is null) 
            return false;
        }
        catch 
        { 
          return false;
        }
      }
      return true;
    }
  }
}
