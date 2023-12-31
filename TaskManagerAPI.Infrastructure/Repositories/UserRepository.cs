﻿using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerAPI.Core.Entities.Base;
using TaskManagerAPI.Infrastructure.Common;
using TaskManagerAPI.Infrastructure.Configurations;
using TaskManagerAPI.Infrastructure.Interfaces;

namespace TaskManagerAPI.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(IConfiguration configuration, TaskManagerContext context) : base(configuration, context)
        {
        }
    }
}
