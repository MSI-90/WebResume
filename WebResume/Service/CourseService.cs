using AutoMapper;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.Extensions.Logging;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Text.Json;

namespace Service
{
  public sealed class CourseService : ICourseService, IEducationCourse<CourseYearDto>
  {
    private readonly ILogger<CourseService> _logger;
    private readonly IMapper _mapper;
    private readonly RepositoryContext _context;
    public CourseService(ILogger<CourseService> logger, IMapper mapper, RepositoryContext context)
    {
      _logger = logger;
      _mapper = mapper;
      _context = context;
    }

    public async Task CreateCourseAsync(ResumeForCreationDto resume)
    {
      var newCourse = DeserialiseCourse(resume);
      await _context.Courses.AddRangeAsync(newCourse);
      await _context.SaveChangesAsync();
    }

    public bool CheckCourseAsValid(ResumeForCreationDto resume)
    {
      if (resume.Course is null || !resume.Course.Any())
        return false;

      return true;
    }

    public List<Course> DeserialiseCourse(ResumeForCreationDto resume)
    {
      if(!CheckCourseAsValid(resume))
        return new List<Course>();

      var newCources = new List<Course>();
      foreach (var item in resume.Course!)
      {
        try
        {
          var courseItem = JsonSerializer.Deserialize<CourseForCreationDto>(item) ?? throw new CourseDeserializeException();
          var newCourse = _mapper.Map<Course>(courseItem);
          newCourse.Id = Guid.NewGuid();
          newCourse.ResumeId = resume.ResumeId!.Value;
          newCources.Add(newCourse);
        }
        catch (JsonException jex)
        {
          _logger.LogWarning(jex.Message);
          throw new CourseDeserializeException();
        }
      }
      return newCources;
    }

    public CourseYearDto? GetEducationYearAndKinds()
    {
      uint minYear = 1950, maxYear = 2050;
      var courseYear = new CourseYearDto();
      for (var i = minYear; i <= maxYear; i++)
      {
        courseYear.YearOfCompleate.Add(i);
      }
      return courseYear;
    }
  }
}
