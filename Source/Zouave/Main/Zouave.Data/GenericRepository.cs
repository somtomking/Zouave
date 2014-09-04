using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zouave.Domain;
using Zouave.Linq.Search;
using Zouave.Linq.Search.Paging;
using Zouave.Linq.Search.Extensions;
namespace Zouave.Data
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly Database _dbDataBase;
        private readonly IDbSet<TEntity> _dbSet;
        private readonly UnitOfWork _unitOfWork;

        public GenericRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
            _dbSet = _unitOfWork.Context.Set<TEntity>();
            _dbDataBase = _unitOfWork.Context.Database;
        }

        public virtual IQueryable<TEntity> Entities
        {
            get { return _dbSet; }
        }

        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> FindAll()
        {
            return _dbSet.ToList();
        }

        public virtual IEnumerable<TEntity> Find(SearchCriteria<TEntity> searchCriteria)
        {
            IQueryable<TEntity> queryable = _dbSet;
            queryable = queryable.SearchBy(searchCriteria);
            return queryable.ToList();
        }

        public virtual PagedResult<TEntity> FindPaged(SearchCriteria<TEntity> searchCriteria)
        {
            int count = _dbSet.FilterBy(searchCriteria.FilterCriterias).Count();
            List<TEntity> entities = _dbSet.SearchBy(searchCriteria).ToList();
            return new PagedResult<TEntity>(count, entities);
        }

        public virtual TEntity Create()
        {
            return _dbSet.Create();
        }

        public virtual void Insert(TEntity entity)
        {

            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(object id)
        {
            TEntity entity = _dbSet.Find(id);
            Delete(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            if (_unitOfWork.Context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public virtual IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters)
        {
            return _dbDataBase.SqlQuery<TElement>(sql, parameters).AsEnumerable();
        }
    }
}
