using School.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
_ = builder.Services.ConfigureDependedServices(builder.Configuration, builder.Logging);

var app = builder.Build();

// Configure the HTTP request pipeline.
_ = app.ConfigureHttpRequestPipeline();

app.Run();

