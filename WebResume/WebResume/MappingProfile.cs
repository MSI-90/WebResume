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
        .ForCtorParam("Experience", opt => opt.MapFrom(x => x.Experience))
        .ForCtorParam("PersonalInfo", opt => opt.MapFrom(x => x.PersonalInfo))
        .ForCtorParam("ContactInfo", opt => opt.MapFrom(x => x.ContactInfo))
        .ForCtorParam("Education", opt => opt.MapFrom(x => x.Education))
        .ForCtorParam("Course", opt => opt.MapFrom(x => x.Courses))
        .ForCtorParam("Languages", opt => opt.MapFrom(x => x.Languages))
        .ForCtorParam("ComputerSkills", opt => opt.MapFrom(x => x.ComputerSkill))
        .ForCtorParam("AdditionalInfo", opt => opt.MapFrom(x => x.AdditionalInfo));

      CreateMap<ResumeDto, Resume>();

      CreateMap<Template, TemplateDto>();

      CreateMap<ResumeForCreationDto, Resume>();

      CreateMap<DesiredJobInfoForCreationDto, JobInfo>();
      CreateMap<JobInfo, DesiredJobInfoOutputDto>();

      CreateMap<Citizenship, CitizenshipDto>();
      CreateMap<Citizenship, CitizenshipOutputDto>();

      CreateMap<PersonalInfo, PersonalInfoDto>();
      CreateMap<PersonalInfoDto, PersonalInfo>();

      CreateMap<ContactInfoForCreationDto,  ContactInfo>();
      CreateMap<ContactInfo,ContactInfoForCreationDto>();
      CreateMap<ContactInfo, ContactInfoOutputDto>();
      CreateMap<SocialNetworkDto, SocialNetworkInfo>();
      CreateMap<SocialNetworkInfo, SocialNetworkOutputDto>();

      CreateMap<ResumeForCreationDto, Resume>()
        .ForMember(dest => dest.Experience, opt => opt.Ignore())
        .ForMember(dest => dest.PersonalInfo, opt => opt.Ignore())
        .ForMember(dest => dest.ContactInfo, opt => opt.Ignore())
        .ForMember(dest => dest.Education, opt => opt.Ignore())
        .ForMember(dest => dest.Languages, opt => opt.Ignore())
        .ForMember(dest => dest.ComputerSkill, opt => opt.Ignore())
        .ForMember(dest => dest.AdditionalInfo, opt => opt.Ignore());

      CreateMap<ExperienceForCreationDto, Experience>();
      CreateMap<Experience, ExperienceOutputDto>();
      CreateMap<ExperienceOutputDto, Experience>();

      CreateMap<EducationForCreationDto, Education>();
      CreateMap<Education, EducationOutputDto>();

      CreateMap<CourseForCreationDto, Course>();
      CreateMap<Course, CourseForOutputDto>();

      CreateMap<LanguageForCreationDto, LanguageInfo>();
      CreateMap<LanguageInfo, LanguageInfoOutputDto>();
      
      CreateMap<Language, LanguageOutputDto>();
      CreateMap<Language, LanguageDto>();

      CreateMap<ComputerSkillForCreationDto, ComputerSkill>();
      CreateMap<ComputerSkill, ComputerSkillOutputDto>();

      CreateMap<AdditionalInfoForCreationDto, AdditionalInformation>();
      CreateMap<AdditionalInformation, AdditionalInfoOutputDto>();
    }
  }
}
