using DataAccess.Repositories.Interfaces;
using Entities.Consts;
using Entities.Entites.Abctract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context.ApplicationContext;

namespace DataAccess.Repositories.Concrete
{
    public class BaseRepository<T>(AppDbContext context) : IBaseRepository<T>
        where T : BaseEntity, new()
    {
        private readonly DbSet<T> _table = context.Set<T>();

        public async Task<bool> SaveAsync() => await context.SaveChangesAsync() > 0 ? true : false;

        public async Task<bool> AddAsync(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = Status.Active;
            await _table.AddAsync(entity);
            return await SaveAsync();
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.Status = Status.Modified;
            _table.Update(entity);
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = Status.Passive;
            _table.Update(entity);
            return await SaveAsync();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression) => await _table.AnyAsync(expression);

        public async Task<T> GetByIdAsync(Expression<Func<T, bool>> expression) => await _table.SingleOrDefaultAsync(expression);
        public async Task<T> GetByEmailAsync(Expression<Func<T, bool>> expression) => await _table.SingleOrDefaultAsync(expression);

        public async Task<T> GetByDefaultAsync(Expression<Func<T, bool>> expression)
        {
            if (expression == null)
                return await _table.FirstOrDefaultAsync();
            return await _table.Where(expression).FirstOrDefaultAsync();
        }

        public async Task<ICollection<T>> GetByDefaultListAsync(Expression<Func<T, bool>> expression)
        {
            if (expression == null)
                return await _table.ToListAsync();
            return await _table.Where(expression).ToListAsync();
        }

        public async Task<ICollection<TResult>> GetFilteredListAsync<TResult>
            (
                Expression<Func<T, TResult>> select, 
                Expression<Func<T, bool>> where = null, 
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, 
                Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                bool asTracking = true,
                CancellationToken cancellationToken = default
            )
        {
            IQueryable<T> query = _table;

            if (!asTracking)
                query = query.AsNoTracking();
            if (include != null)
                query = include(query);
            if (where != null)
                query = query.Where(where);
            if (orderBy != null)
                return await orderBy(query).Select(select).ToListAsync(cancellationToken);

            return await query.Select(select).ToListAsync(cancellationToken);
        }
    }
}