using Application.Interfaces;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static  class ServiceExtension
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ISchoolService, SchoolService>();
        services.AddScoped<SchoolService2>();
        services.AddScoped<WrapperService>();
        return services;
    }

}
