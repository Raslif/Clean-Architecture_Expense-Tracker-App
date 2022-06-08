using Microsoft.Extensions.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace ExpenseTracker.Infrastructure.Persistance.Data
{
    public class DbConnector
    {
        private readonly IConfiguration _configuration = null;
        protected DbConnector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbConnection GetConnection
        {
            get
            {
                return new SqlConnection(_configuration.GetConnectionString("ExpenseTrackerContext"));
            }
        }
    }
}
