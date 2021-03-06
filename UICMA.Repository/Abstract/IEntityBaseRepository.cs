﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using UICMA.Domain.Entities;

namespace UICMA.Repository
{
    
        public interface IEntityBaseRepository<T> where T : class, IBaseEntity, new()
        {
            IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
            IEnumerable<T> GetAll();
            int Count();
            T GetSingle(int id);
            T GetSingle(Expression<Func<T, bool>> predicate);
            T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
            IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
            void DeleteWhere(Expression<Func<T, bool>> predicate);
            void SaveChanges();
            T AddData(T entity);
            T UpdateData(T entity);
        }
    
}
