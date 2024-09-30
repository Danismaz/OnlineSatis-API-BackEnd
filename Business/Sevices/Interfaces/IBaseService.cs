using System.Linq.Expressions;
using DataAccess.Repositories.Interfaces;
using DataTransfer.Abstract;
using Entities.Entites.Abctract;
using Microsoft.EntityFrameworkCore.Query;

namespace Business.Sevices.Interfaces;

public interface IBaseService<A, C>
    where A: IBaseRepository<C>
    where C: BaseEntity
{
        Task<bool> AddAsync(BaseDto dto);
        Task<bool> UpdateAsync(BaseDto dto);
        Task<bool> DeleteAsync(BaseDto dto);
        Task<bool> SaveAsync();

        //READ Operations
        Task<T> GetByIdAsync<T>(Expression<Func<C, bool>> expression);
        Task<T> GetByEmailAsync<T>(Expression<Func<C, bool>> expression);
        Task<T> GetByDefaultAsync<T>(Expression<Func<C, bool>> expression);
        Task<ICollection<T>> GetByDefaultListAsync<T>(Expression<Func<C, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<C, bool>> expression);
        Task<ICollection<TResult>> GetFilteredListAsync<TResult>
            (
                Expression<Func<C, TResult>> select,
                Expression<Func<C, bool>> where = null,
                Func<IQueryable<C>, IOrderedQueryable<C>> orderBy = null,
                Func<IQueryable<C>, IIncludableQueryable<C, object>> include = null,
                bool enableTracking = true,
                CancellationToken cancellationToken = default
           );
    
}

