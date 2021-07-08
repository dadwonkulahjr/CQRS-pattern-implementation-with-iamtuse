using Microsoft.Extensions.DependencyInjection;
using MyAppCQRSPattern.Application.Common.Interfaces;
using MyAppCQRSPattern.Application.Students.Queries.GetStudents;

namespace MyAppCQRSPattern.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IGetStudentListQuery, GetStudentQuery>();
            return services;
        }
    }
}
