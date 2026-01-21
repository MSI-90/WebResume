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

    public async Task CreateCourseAsync(ResumeForCreationDTO resume)
    {
      if (!CheckCourseAsValid(resume)) return;

      var newCources = new List<Course>();
      foreach (var item in resume.Course!)
      {
        var newCourse = _mapper.Map<Course>(item);
        newCourse.Id = Guid.NewGuid();
        newCourse.ResumeId = resume.ResumeId!.Value;
        newCources.Add(newCourse);
      }

      await _context.Courses.AddRangeAsync(newCources);
      await _context.SaveChangesAsync();
    }

    public bool CheckCourseAsValid(ResumeForCreationDTO resume) =>
      resume.Course is not null && resume.Course.Any();

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
