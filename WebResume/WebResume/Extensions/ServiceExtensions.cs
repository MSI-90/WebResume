using AutoMapper;
using Contracts;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Service;
using Service.BackgroundServices;
using Service.Contracts;
using WebResume.Presentation.ActionFilters;

namespace WebResume.Extensions
{
  public static class ServiceExtensions
  {
    public static void ConfigurePostgresConnection(this IServiceCollection services, IConfiguration configuration) =>
      services.AddDbContext<RepositoryContext>(options => options.UseNpgsql(configuration.GetConnectionString("sqlConnection")));
    
    public static void ConfigureCors(this IServiceCollection services) =>
      services.AddCors(options =>
      {
        options.AddPolicy("CorsPolicy", builder =>
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
      });

    public static void ConfigureIISIntegration(this IServiceCollection services) =>
      services.Configure<IISServerOptions>(options =>
      {
      });

    public static void ConfigureLoggerService(this IServiceCollection services) =>
      services.AddSingleton<ILoggerManager, LoggerManager>();

    public static void ConfigureService(this IServiceCollection services)
    {
      services.AddScoped<TextJsonFilter>();
      services.AddScoped<IResumeService, ResumeService>();
      services.AddScoped<ITemplateService, TemplateService>();
      services.AddScoped<ISpecialInfoService, SpecialInfoService>();
      services.AddScoped<IJobInfoService, JobInfoService>();
      services.AddScoped<ICitizenshipService, CitizenshipService>();
      services.AddScoped<IBufferInfo, BufferInfo>();
      services.AddScoped<IPhotoService, PhotoService>();
      services.AddScoped<IExperienceService, ExperienceService>();
      services.AddScoped<IFileService, FileService>(sp =>
      {
        var config = sp.GetRequiredService<IConfiguration>();
        var env = sp.GetRequiredService<IHostEnvironment>();
        var uploadsPath = Path.Combine(env.ContentRootPath, config["FileStorage"]!);

        return new FileService(
          sp.GetRequiredService<ILoggerManager>(),
          uploadsPath,
          sp.GetRequiredService<IPhotoService>());
      });
    }

    public static void ConfigureHostedServices(this IServiceCollection services)
    {
      services.AddHostedService<DeletePhoto>();
    }
  }
}
