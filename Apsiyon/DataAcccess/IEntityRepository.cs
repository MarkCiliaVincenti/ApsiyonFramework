﻿using Apsiyon.Entities.Abstract;
using Apsiyon.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Apsiyon.DataAcccess
{
    public interface IEntityRepository<T> where T : Entity, new()
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, PaginationQuery paginationQuery = null, params Expression<Func<T, object>>[] includeEntities);
        Task<T> GetAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeEntities);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
