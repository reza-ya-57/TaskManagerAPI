using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            services.AddScoped<IUserRepository , UserRepository>();
            return services;
        }
    }
}
