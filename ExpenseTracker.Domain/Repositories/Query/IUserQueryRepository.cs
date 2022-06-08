using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseTracker.Domain.Repositories.Query
{
    public interface IUserQueryRepository : IQueryRepository<User>
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> GetUserByEmail(string email);
    }
}
