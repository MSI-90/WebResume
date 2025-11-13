using Contracts;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service;
using Service.Contracts;

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
      services.AddScoped<IResumeService, ResumeService>();
      services.AddScoped<ITemplateService, TemplateService>();
      services.AddScoped<ISpecialInfoService, SpecialInfoService>();
    }
  }
}
