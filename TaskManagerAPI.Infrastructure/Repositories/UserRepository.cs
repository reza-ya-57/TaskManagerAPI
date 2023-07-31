using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
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
    public class UserRepository : BaseRepository<User> , IUserRepository
    {
        public UserRepository(IConfiguration configuration, TaskManagerContext context) : base(configuration, context)
        {
        }

        public User GetUserByUserName(string userName)
        {
            using var connection = _context.CreateConnection();
            connection.Open();
            string query = $"SELECT * FROM [Base].[User] WHERE UserName LIKE '{userName}'";
            var user = connection.Query<User>(query).FirstOrDefault();
            return user;
        }
    }
}
