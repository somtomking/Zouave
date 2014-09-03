using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Zouave.Linq.Search.Paging;
using Zouave.Linq.Search.Sort;

namespace Zouave.Linq.Search.Extensions
{
    public static class QueryableExtension
    {
        public static IQueryable<TEntity> SearchBy<TEntity>(this IQueryable<TEntity> source, SearchCriteria<TEntity> searchCriteria)
            where TEntity : class
        {
            IQueryable<TEntity> queryable = source;
            queryable = queryable.FilterBy(searchCriteria.FilterCriterias);
            queryable = queryable.OrderBy(searchCriteria.SortCriterias);
            queryable = queryable.PageBy(searchCriteria.PagingCriteria);
            return queryable;
        }

        public static IQueryable<TEntity> FilterBy<TEntity>(this IQueryable<TEntity> source, IList<Expression<Func<TEntity, bool>>> criterias)
            where TEntity : class
        {
            IQueryable<TEntity> queryable = source;
            if (criterias.Count > 0)
            {
                queryable = criterias.Aggregate(source, (current, filter) => current.Where(filter));
            }
            return queryable;
        }

        public static IQueryable<TEntity> OrderBy<TEntity>(this IQueryable<TEntity> source, IList<ISortCriteria<TEntity>> criterias)
            where TEntity : class
        {
            IQueryable<TEntity> queryable;
            if (criterias.Count > 0)
            {
                ISortCriteria<TEntity> firstSortCriteria = criterias[0];
                IOrderedQueryable<TEntity> orderedQueryable = firstSortCriteria.Apply(source, false);
                if (criterias.Count > 1)
                {
                    for (int i = 1; i < criterias.Count; i++)
                    {
                        ISortCriteria<TEntity> sortCriteria = criterias[i];
                        orderedQueryable = sortCriteria.Apply(orderedQueryable, true);
                    }
                }
                queryable = orderedQueryable;
            }
            else
            {
                queryable = source.OrderBy(x => 0);
            }
            return queryable;
        }

        public static IQueryable<TEntity> PageBy<TEntity>(this IQueryable<TEntity> source, PagingCriteria criteria)
            where TEntity : class
        {
            IQueryable<TEntity> queryable = source;
            if (criteria != null)
            {
                int skipCount = criteria.PageIndex*criteria.PageSize;
                int takeCount = criteria.PageSize;
                queryable = source.Skip(skipCount).Take(takeCount);
            }
            return queryable;
        }
    }
}