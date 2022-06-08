using ExpenseTracker.Domain.Repositories.Base;
using ExpenseTracker.Infrastructure.Persistance.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ExpenseTracker.Infrastructure.Persistance.MSSQL.Repositories.Base
{
    public class CommandRepository<T> : ICommandRepository<T> where T : class
    {
        protected readonly ExpenseTrackerContext _context = null;

        public CommandRepository(ExpenseTrackerContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
