using Entities.Entites.Abctract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<bool> SaveAsync();

        //READ Operations
        Task<T> GetByIdAsync(Expression<Func<T, bool>> expression);
        Task<T> GetByEmailAsync(Expression<Func<T, bool>> expression);
        Task<T> GetByDefaultAsync(Expression<Func<T, bool>> expression);
        Task<ICollection<T>> GetByDefaultListAsync(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<ICollection<TResult>> GetFilteredListAsync<TResult>(
           Expression<Func<T, TResult>> select,
           Expression<Func<T, bool>> where = null,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
           bool enableTracking = true,
           CancellationToken cancellationToken = default);
    }
}
