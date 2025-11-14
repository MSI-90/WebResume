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
        opt => opt.MapFrom(x => string.Join(' ', x.LastName, x.FirstName, x.MiddleName)));

      CreateMap<Template, TemplateDto>();
    }
  }
}
