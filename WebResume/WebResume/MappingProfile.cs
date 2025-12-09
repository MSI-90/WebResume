using AutoMapper;
using Entites.Models;
using Shared.DataTransferObjects;

namespace WebResume
{
  public class MappingProfile : Profile
  {
    public MappingProfile() 
    {
      CreateMap<Resume, ResumeDto>()
        .ForCtorParam("FIO",
          opt => opt.MapFrom(x => string.Join(' ', x.LastName, x.FirstName, x.MiddleName)))
        .ForCtorParam("DesiredJob", opt => opt.MapFrom(x => x.Job))
        .ForCtorParam("Experience", opt => opt.MapFrom(x => x.Experience));

      CreateMap<ResumeDto, Resume>();

      CreateMap<Template, TemplateDto>();

      CreateMap<ResumeForCreationDto, Resume>();

      CreateMap<DesiredJobInfoForCreationDto, JobInfo>();

      CreateMap<JobInfo, DesiredJobInfoOutputDto>();

      CreateMap<Citizenship, CitizenshipDto>();

      CreateMap<ResumeForCreationDto, Resume>()
        .ForMember(dest => dest.Experience, opt => opt.Ignore());

      CreateMap<ExperienceForCreationDto, Experience>();
      CreateMap<Experience, ExperienceOutputDto>();
      CreateMap<ExperienceOutputDto, Experience>();
    }
  }
}
