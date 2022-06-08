using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Repositories.Command;
using ExpenseTracker.Infrastructure.Persistance.Data;
using ExpenseTracker.Infrastructure.Persistance.MSSQL.Repositories.Base;
using System.Threading.Tasks;

namespace ExpenseTracker.Infrastructure.Persistance.MSSQL.Repositories.Commad
{
    public class UserCommandRepository : CommandRepository<User>, IUserCommandRepository
    {
        public UserCommandRepository(ExpenseTrackerContext context) : base(context)
        {

        }

        public async Task<User> AddUser(User user)
        {
            return await AddAsync(user);
        }

        public async Task UpdateUser(User user)
        {
            await UpdateAsync(user);
        }

        public async Task DeleteUser(User user)
        {
            await DeleteAsync(user);
        }
    }
}
