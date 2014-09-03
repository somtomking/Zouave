using System;
using System.Linq;

namespace Zouave.Linq.Search.Sort
{
    public interface ISortCriteria<T>
    {
        SortDirection Direction { get; set; }
        IOrderedQueryable<T> Apply(IQueryable<T> query, Boolean useThenBy);
    }
}