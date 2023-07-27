using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerAPI.Core.Entities.Base;
using TaskManagerAPI.Infrastructure.Configurations;
using TaskManagerAPI.Infrastructure.Interfaces;

namespace TaskManagerAPI.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IConfiguration _configuration { get; }
        private readonly string _connectionString;
        private TaskManagerContext _context;

        public UserRepository(IConfiguration configuration , TaskManagerContext context)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("Develop");
            _context = context;
        }

        public async Task<List<User>> GetAllAsync()
        {
           try
            {
                using var connection = _context.CreateConnection();
                string query = "SELECT * FROM [Base].[User]";
                var users = await connection.QueryAsync<User>(query);
                var result = users.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task UpdateByIdAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
