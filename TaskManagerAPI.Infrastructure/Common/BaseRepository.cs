using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerAPI.Core.Common;
using TaskManagerAPI.Core.Entities.Base;
using TaskManagerAPI.Infrastructure.Configurations;
using TaskManagerAPI.Infrastructure.Interfaces;

namespace TaskManagerAPI.Infrastructure.Common
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private IConfiguration _configuration { get; }
        protected TaskManagerContext _context;

        public BaseRepository(IConfiguration configuration, TaskManagerContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            try
            {
                using var connection = _context.CreateConnection();
                connection.Open();
                string query = $"SELECT * FROM [Base].[{typeof(T).Name}]";
                var users = await connection.QueryAsync<T>(query);
                var result = users.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<T> GetByIdAsync(long entityId)
        {
            // define parameter
            var paramteres = new DynamicParameters();
            paramteres.Add("@EntityId", entityId);
            // create connection
            using var connection = _context.CreateConnection();
            connection.Open();
            // create query
            string query = $"SELECT * FROM [Base].[{typeof(T).Name}] WHERE Id = @EntityId";
            // execute query
            var user = await connection.QueryAsync<T>(query, paramteres);
            var result = user.FirstOrDefault();
            return result;
        }
        public Task UpdateByIdAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(long entityId)
        {
            throw new NotImplementedException();
        }



        public class EntityQueryParameters
        {
            public long EntityId { get; set; }
        }
    }
}
