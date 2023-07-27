using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerAPI.Infrastructure.Configurations
{
    public class TaskManagerContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public TaskManagerContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = configuration.GetConnectionString("Develop");
        }


        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
