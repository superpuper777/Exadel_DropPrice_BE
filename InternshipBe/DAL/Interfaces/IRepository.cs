﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        IEnumerable<TEntity> Find(Func<TEntity, Boolean> predicate);

        void Create(TEntity item);

        IQueryable<TEntity> GetSpecifiedAmount(int skip, int take);
    }
}
