using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Repositories.Base;
using System.Threading.Tasks;

namespace ExpenseTracker.Domain.Repositories.Command
{
    public interface IUserCommandRepository : ICommandRepository<User>
    {
        Task<User> AddUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(User user);
    }
}
