using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using UICMA.Domain.Entities;

namespace UICMA.Repository
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IBaseEntity, new()
    {

        private readonly UICMAContext _context;

        #region Properties
        public EntityBaseRepository(UICMAContext context)
        {
            _context = context;
        }
        #endregion
        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsEnumerable();
        }

        public virtual int Count()
        {
            return _context.Set<T>().Count();
        }
        public virtual IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.AsEnumerable();
        }

        public T GetSingle(int id)
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return query.Where(predicate).FirstOrDefault();
        }

        public virtual IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public virtual void Add(T entity)
        {
            EntityEntry dbEntityEntry = _context.Entry(entity);
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            EntityEntry dbEntityEntry = _context.Entry(entity);
            dbEntityEntry.State = EntityState.Modified;
            _context.SaveChanges();
        }


        public  T AddData (T entity)
        {
            EntityEntry dbEntityEntry = _context.Entry(entity);
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }


        public  T UpdateData(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.Entry(entity).Property("ModifiedOn").CurrentValue= DateTime.Now;
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.Entry(entity).Property("CreatedOn").IsModified = false;
            _context.SaveChanges();



            //EntityEntry dbEntityEntry = _context.Entry(entity);

            //dbEntityEntry.State = EntityState.Modified;

            //_context.SaveChanges();
            return entity;


           
        }



        public virtual void Delete(T entity)
        {
            EntityEntry dbEntityEntry = _context.Entry(entity);
            dbEntityEntry.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public virtual void DeleteWhere(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> entities = _context.Set<T>().Where(predicate);

            foreach (var entity in entities)
            {
                _context.Entry<T>(entity).State = EntityState.Deleted;
            }
            _context.SaveChanges();
        }

        public virtual void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
