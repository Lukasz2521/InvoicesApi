using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Linq;
using System.Data.SqlClient;

namespace Invoices.Infrastructure.Repositories
{
    public class BaseRespository
    {
        IConfiguration _configuration;
        IDbConnection _connection;

        public BaseRespository()
        {

        }

        public BaseRespository(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        protected List<T> Query<T>(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                return connection.Query<T>(sql, parameters).ToList();
            }
        }

        protected int Execute(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                return connection.Execute(sql, parameters);
            }
        }

        private IDbConnection CreateConnection()
        {
            var connection = new SqlConnection(this.GetConnectionString());
            return connection;
        }

        private string GetConnectionString()
        {
            return "Server=(localdb)\\V11.0;Database=Invoice;Trusted_Connection=True"; //_configuration.GetSection("Data").GetSection("ConnectionString").Value;
        }
    }
}
