using System.Linq.Expressions;
using AutoMapper;
using Business.Sevices.Interfaces;
using DataAccess.Repositories.Interfaces;
using DataTransfer.Abstract;
using Entities.Consts;
using Entities.Entites.Abctract;
using Microsoft.EntityFrameworkCore.Query;

namespace Business.Sevices.Concrete;

public abstract class BaseService<A, C>(A repository, IMapper mapper) : IBaseService<A, C>
    where A : IBaseRepository<C>
    where C : BaseEntity
{
    private readonly A _repository = repository;

    public async Task<bool> AddAsync(BaseDto dto)
    => await _repository.AddAsync(mapper.Map<C>(dto));

    public async Task<bool> UpdateAsync(BaseDto dto)
    => await _repository.UpdateAsync(mapper.Map<C>(dto));

    public async Task<bool> DeleteAsync(BaseDto dto)
        => await _repository.DeleteAsync(mapper.Map<C>(dto));

    public async Task<bool> SaveAsync()
        => await _repository.SaveAsync();

    public async Task<T> GetByIdAsync<T>(Expression<Func<C, bool>> expression)
    => mapper.Map<T>(await _repository.GetByIdAsync(expression));

    public async Task<T> GetByEmailAsync<T>(Expression<Func<C, bool>> expression)
    => mapper.Map<T>(await _repository.GetByEmailAsync(expression));

    public async Task<T> GetByDefaultAsync<T>(Expression<Func<C, bool>> expression)
        => mapper.Map<T>(await _repository.GetByDefaultAsync(expression));
    
    public async Task<ICollection<T>> GetByDefaultListAsync<T>(Expression<Func<C, bool>> expression)
    => mapper.Map<ICollection<T>>(await _repository.GetByDefaultListAsync(expression));

    public async Task<bool> AnyAsync(Expression<Func<C, bool>> expression)
        => await _repository.AnyAsync(expression);

    public async Task<ICollection<TResult>> GetFilteredListAsync<TResult>(
        Expression<Func<C, TResult>> select,
        Expression<Func<C, bool>> where = null,
        Func<IQueryable<C>, IOrderedQueryable<C>> orderBy = null,
        Func<IQueryable<C>, IIncludableQueryable<C, object>> include = null,
        bool enableTracking = true,
        CancellationToken cancellationToken = default)
        => (ICollection<TResult>)await _repository.GetFilteredListAsync(select, where, orderBy, include, enableTracking, cancellationToken);
}