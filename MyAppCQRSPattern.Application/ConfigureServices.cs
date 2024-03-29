﻿using MediatR;
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
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
