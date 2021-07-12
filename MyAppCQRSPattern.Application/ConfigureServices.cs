using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MyAppCQRSPattern.Application.Services.Repository;
using MyAppCQRSPattern.Application.Services.Repository.IRepository;
using System.Reflection;

namespace MyAppCQRSPattern.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IGenderRepository, GenderRepository>();
            services.AddMediatR(assemblies: Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
