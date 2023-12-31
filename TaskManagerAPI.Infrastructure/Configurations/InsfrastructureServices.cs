﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerAPI.Core.Entities.Base;
using TaskManagerAPI.Infrastructure.Common;
using TaskManagerAPI.Infrastructure.Configurations;
using TaskManagerAPI.Infrastructure.Interfaces;
using TaskManagerAPI.Infrastructure.Repositories;

namespace TaskManagerAPI.Insfrastructure.Configurations
{
    public static class InsfrastructureServices
    {
        public static IServiceCollection AddInsfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton<TaskManagerContext>();
            //services.AddScoped<IUserRepository , UserRepository>();
            services.AddScoped<IBaseRepository<User>, UserRepository>();
            services.AddScoped<IBaseRepository<Person> , PersonRepositroy>();
            return services;
        }
    }
}
