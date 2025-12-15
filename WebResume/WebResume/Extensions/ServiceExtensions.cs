using Microsoft.EntityFrameworkCore;
using Npgsql;
using Repository;
using Service;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace WebResume.Extensions
{
  public static class ServiceExtensions
  {
    public static void ConfigurePostgresConnection(this IServiceCollection services, IConfiguration configuration)
    {
      // Создаём источник данных с включённой поддержкой POCO-сериализации
      var dataSource = new NpgsqlDataSourceBuilder(configuration.GetConnectionString("sqlConnection"))
          .EnableDynamicJson()
          .Build();

      // Добавляем DbContext, передавая ему уже настроенный источник данных
      services.AddDbContext<RepositoryContext>(options =>
          options.UseNpgsql(dataSource));
    }
    
    public static void ConfigureCors(this IServiceCollection services) =>
      services.AddCors(options =>
      {
        options.AddPolicy("CorsPolicy", builder =>
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
      });

    public static void ConfigureIISIntegration(this IServiceCollection services) =>
      services.Configure<IISServerOptions>(options => {});

    public static void ConfigureService(this IServiceCollection services)
    {
      services.AddScoped<IResumeService, ResumeService>();
      services.AddScoped<ITemplateService, TemplateService>();
      services.AddScoped<ISpecialInfoService, SpecialInfoService>();
      services.AddScoped<IJobInfoService, JobInfoService>();
      services.AddScoped<ICitizenshipService, CitizenshipService>();
      services.AddScoped<IPhotoService, PhotoService>();
      services.AddScoped<IExperienceService, ExperienceService>();
      services.AddScoped<IS3StorageService, S3StorageService>();
      services.AddScoped<IPersonalInfoService, PersonalInfoService>();
      services.AddScoped<ISocialNetworkService, SocialNetworkService>();
      services.AddScoped<IContactInfoService, ContactInfoService>();
      services.AddScoped<IEducationService, EducationService>();
    }

    public static void ConfigureOptionsConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
      services.Configure<RegRuS3Dto>(configuration.GetSection("regru"));
    }
  }
}
