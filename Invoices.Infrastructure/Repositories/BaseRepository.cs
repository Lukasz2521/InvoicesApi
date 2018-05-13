using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Invoices.Infrastructure.Repositories
{
    public class BaseRespository
    {
        IConfiguration _configuration;

        public BaseRespository()
        {

        }

        public BaseRespository(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        protected async Task<IEnumerable<T>> Query<T>(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                return await connection.QueryAsync<T>(sql, parameters);
            }
        }

        protected async Task<T> QuerySingle<T>(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                var result = await connection.QuerySingleAsync<T>(sql, parameters);

                return result;
            }
        }

        protected async Task<int> Execute(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                return await connection.ExecuteAsync(sql, parameters);
            }
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(this.GetConnectionString());
        }

        private string GetConnectionString()
        {
            return "Server=(localdb)\\V11.0;Database=Invoice;Trusted_Connection=True"; //_configuration.GetSection("Data").GetSection("ConnectionString").Value;
        }
    }
}
