using Dapper;
using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Repositories.Query;
using ExpenseTracker.Infrastructure.Persistance.MSSQL.Repositories.Base;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Infrastructure.Persistance.MSSQL.Repositories.Query
{
    public class UserQueryRepository : QueryRepository<User>, IUserQueryRepository
    {
        public UserQueryRepository(IConfiguration configuration)
            : base(configuration)
        {

        }

        public async Task<List<User>> GetAllAsync()
        {
            try
            {
                var query = "SELECT * FROM Users with(nolock)";

                using (var connection = GetConnection)
                {
                    return (await connection.QueryAsync<User>(query)).ToList();
                }
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public Task<User> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetUserByEmail(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}
