using ExpenseTracker.Domain.Repositories.Base;
using ExpenseTracker.Infrastructure.Persistance.Data;
using Microsoft.Extensions.Configuration;

namespace ExpenseTracker.Infrastructure.Persistance.MSSQL.Repositories.Base
{
    public class QueryRepository<T> : DbConnector, IQueryRepository<T> where T : class
    {
        public QueryRepository(IConfiguration configuration)
            : base(configuration)
        {

        }
    }
}
