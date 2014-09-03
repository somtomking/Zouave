using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Zouave.Linq.Search.Paging;
using Zouave.Linq.Search.Sort;

namespace Zouave.Linq.Search
{
    public class SearchCriteria<TEntity>
    {
        private readonly IList<Expression<Func<TEntity, bool>>> _filterCriterias;
        private readonly IList<ISortCriteria<TEntity>> _sortCriterias;

        public SearchCriteria()
        {
            _filterCriterias = new List<Expression<Func<TEntity, bool>>>();
            _sortCriterias = new List<ISortCriteria<TEntity>>();
        }

        public IList<Expression<Func<TEntity, bool>>> FilterCriterias
        {
            get { return _filterCriterias; }
        }

        public IList<ISortCriteria<TEntity>> SortCriterias
        {
            get { return _sortCriterias; }
        }

        public PagingCriteria PagingCriteria { get; set; }

        public void AddFilterCriteria(Expression<Func<TEntity, Boolean>> filter)
        {
            FilterCriterias.Add(filter);
        }

        public void AddSortCriteria(ISortCriteria<TEntity> sortCriteria)
        {
            SortCriterias.Add(sortCriteria);
        }
    }
}