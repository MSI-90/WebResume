using AutoMapper;
using Entites.Enums;
using Entites.Enums.Extends;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.Extensions.Logging;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Text.Json;

namespace Service
{
  /// <summary>
  /// Сервис для работы с личной информацией резюме
  /// </summary>
  public sealed class PersonalInfoService : IPersonalInfoService
  {
    private readonly ILogger<PersonalInfoService> _logger;
    private readonly RepositoryContext _context;
    private readonly IMapper _mapper;
    private readonly ICitizenshipService _citizenshipService;
    public PersonalInfoService(
      ILogger<PersonalInfoService> logger, 
      RepositoryContext context, 
      IMapper mapper, 
      ICitizenshipService citizenshipService) 
    {
      _logger = logger;
      _context = context;
      _mapper = mapper;
      _citizenshipService = citizenshipService;
    }

    /// <summary>
    /// Добвить в твблицу БД личную информацию в рамках резюме.
    /// </summary>
    /// <param name="resumeDto">резюме объект со всеми возможными вариантами из которых создается резюме</param>
    /// <returns>Задача</returns>
    public async Task CreatePersonalInfoAsync(ResumeForCreationDto resumeDto) 
    { 
      var pInfo = DeserializePInfo(resumeDto);
      if (pInfo is null)
        return;

      var newPersonalInfo = _mapper.Map<PersonalInfo>(pInfo);
      newPersonalInfo.Id = Guid.NewGuid();
      newPersonalInfo.ResumeId = resumeDto.ResumeId;
      newPersonalInfo.Citizenships = await _citizenshipService.GetCitizenShipsThenAnyAsync(resumeDto.CitizenshipIds);

      await _context.PersonalInfos.AddAsync(newPersonalInfo);
      await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Проверка на наличие раздела личной информации
    /// </summary>
    /// <param name="resumeDto">резюме объект со всеми возможными вариантами из которых создается резюме</param>
    /// <returns>булевый параметр</returns>
    public bool CheckPInfoAsValid(ResumeForCreationDto resumeDto)
    {
      if (resumeDto is null || string.IsNullOrWhiteSpace(resumeDto.PersonalInfo))
      {
        _logger.LogWarning("Раздел, личная информация отстуствует");
        return false;
      }
      return true;
    }

    /// <summary>
    /// Десериализация JSON объекта личной информации в DTO PersonalInfoDTO
    /// </summary>
    /// <param name="resumeDto">резюме объект со всеми возможными вариантами из которых создается резюме</param>
    /// <returns>PersonalInfoDTO</returns>
    /// <exception cref="PersonalInfoDeserializeException">Вариант исключения при десериализации, используется в глобальном UseExceptionHandler, вернет 422</exception>
    public PersonalInfoDTO? DeserializePInfo(ResumeForCreationDto resumeDto)
    {
      if (!CheckPInfoAsValid(resumeDto))
        return null;

      try
      {
        return JsonSerializer.Deserialize<PersonalInfoDTO>(resumeDto.PersonalInfo!) ?? throw new PersonalInfoDeserializeException();
      }
      catch (JsonException jex)
      {
        _logger.LogError(jex.Message);
        throw new PersonalInfoDeserializeException();
      }
    }

    /// <summary>
    /// Варианты переезда
    /// </summary>
    /// <returns>Список вариантов переезда</returns>
    public IEnumerable<MovingVariantDTO> MovingVariants()
    {
      var movingVariants = Enum.GetValues<Moving>();
      return movingVariants.Select(mv => new MovingVariantDTO
      {
        Id = (byte)mv,
        VariantEn = mv.ToString(),
        VariantRu = mv.GetDisplayName()
      });
    }

    /// <summary>
    /// Пол
    /// </summary>
    /// <returns>Списко вариантов пола</returns>
    public IEnumerable<SexVariantDTO> SexVariant()
    {
      var sexVariants = Enum.GetValues<Sex>();
      return sexVariants.Select(sv => new SexVariantDTO
      {
        Id = (byte)sv,
        SexEn = sv.ToString(),
        SexRu = sv.GetDisplayName()
      });
    }

    /// <summary>
    /// Семейное положение
    /// </summary>
    /// <returns>Список вариантов семейного положения</returns>
    public IEnumerable<MaritalStatustDTO> MaritalStatusVariants()
    {
      var maritalStatusVariants = Enum.GetValues<MaritalStatus>();
      return maritalStatusVariants.Select(ms => new MaritalStatustDTO
      {
        Id = (byte)ms,
        StatusEn = ms.ToString(),
        StatusRu = ms.GetDisplayName()
      });
    }
  }
}