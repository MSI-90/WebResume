using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;
using WebResume;
using WebResume.Extensions;

var builder = WebApplication.CreateBuilder(args);

// NLog
LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Automapper
builder.Services.AddAutoMapper(typeof(Program));

// Add services to the container.

// For Caustom ModelState Error model using. For exclude (400 BadRequest if a ModelState is invalid)
//builder.Services.Configure<ApiBehaviorOptions>(options =>
//{
//  options.SuppressModelStateInvalidFilter = true;
//});

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

if (app.Environment.IsDevelopment())
  app.UseDeveloperExceptionPage();
else
  app.UseHsts();

app.UseStaticFiles();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
  ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

app.UseExceptionHandler(opt => { });

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
