using Microsoft.EntityFrameworkCore;
using School.API.ApplicationCore.Interfaces;
using School.API.Business;
using School.API.Configurations;
using School.API.Persistence;
using School.API.Repositories;
using Serilog;

namespace School.API.Extensions;

public static class DependedServicesExtensions
{

    public static IServiceCollection ConfigureDependedServices(this IServiceCollection services, IConfiguration configuration, ILoggingBuilder loggingBuilder)
    {
        var logger = new LoggerConfiguration()
                    .WriteTo.Debug()
                    .WriteTo.Console()
                    .ReadFrom.Configuration(configuration)
                    .Enrich.FromLogContext()
                    .CreateLogger();

        loggingBuilder.ClearProviders();
        loggingBuilder.AddSerilog(logger);

        string sqlConnectionString = configuration.GetConnectionString(AzSQLServerDatabase.Name)!;

        _ = services.AddDbContext<SchoolDbContext>(options =>
            options.UseSqlServer(sqlConnectionString));

        _ = services.AddAutoMapper(typeof(AutoMapperConfig));

        _ = services.AddScoped<ICoursesBusiness, CoursesBusiness>();

        _ = services.AddScoped<ICoursesRepository, CoursesRepository>();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        _ = services.AddEndpointsApiExplorer();
        _ = services.AddSwaggerGen();

        _ = services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", policy => policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
        });

        return services;
    }
}
