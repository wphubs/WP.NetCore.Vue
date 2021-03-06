﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WP.NetCore.Model;

namespace WP.NetCore.IServices
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<PageModel<TEntity>> GetPageListAsync(int pageIndex, int pageSize);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(long Id);

        Task<TEntity> AddAsync(TEntity entity);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> FirstAsync(long Id);

        Task<TEntity> FirstNoTrackingAsync(long Id);
    }
}
