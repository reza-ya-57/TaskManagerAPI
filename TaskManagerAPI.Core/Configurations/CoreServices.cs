using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerAPI.Core.Configurations
{
    public static class CoreServices
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
