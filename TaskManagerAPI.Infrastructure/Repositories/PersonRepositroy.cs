using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerAPI.Core.Entities.Base;
using TaskManagerAPI.Infrastructure.Common;
using TaskManagerAPI.Infrastructure.Configurations;

namespace TaskManagerAPI.Infrastructure.Repositories
{
    public class PersonRepositroy : BaseRepository<Person>
    {
        public PersonRepositroy(IConfiguration configuration, TaskManagerContext context) : base(configuration, context)
        {
        }
    }
}
