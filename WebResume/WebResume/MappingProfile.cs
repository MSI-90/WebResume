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
        .ForCtorParam("Photo", opt => opt.MapFrom(x => x.PhotoFile))
        .ForCtorParam("DesiredJob", opt => opt.MapFrom(x => x.Job));

      CreateMap<ResumeDto, Resume>();

      CreateMap<Template, TemplateDto>();

      CreateMap<ResumeForCreationDto, Resume>();

      CreateMap<Photo, PhotoDto>();

      CreateMap<DesiredJobInfoForCreationDto, JobInfo>();

      CreateMap<JobInfo, DesiredJobInfoOutputDto>();

      CreateMap<Citizenship, CitizenshipDto>();
    }
  }
}
