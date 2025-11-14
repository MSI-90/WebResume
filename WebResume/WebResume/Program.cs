using NLog;
using WebResume;
using WebResume.Extensions;

var builder = WebApplication.CreateBuilder(args);

// NLog
LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Automapper
builder.Services.AddAutoMapper(typeof(Program));

// Add services to the container.

builder.Services.AddControllers()
  .AddApplicationPart(typeof(WebResume.Presentation.AssemblyReference).Assembly);

builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();

// IOC
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureService();
builder.Services.ConfigurePostgresConnection(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseExceptionHandler(opt => { });

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
