using System;
using System.Linq;
using Zouave.Linq;

namespace Zouave.Linq.Search.Sort
{
    public class FieldSortCriteria<T> : ISortCriteria<T> where T : class
    {
        public FieldSortCriteria()
        {
            Direction = SortDirection.Ascending;
        }

        public FieldSortCriteria(String name, SortDirection direction)
        {
            Name = name;
            Direction = direction;
        }

        public String Name { get; set; }

        public SortDirection Direction { get; set; }

        public IOrderedQueryable<T> Apply(IQueryable<T> qry, Boolean useThenBy)
        {
            bool isDescending = Direction == SortDirection.Descending;
            IOrderedQueryable<T> result = !useThenBy ? qry.OrderBy(Name, isDescending) : qry.ThenBy(Name, isDescending);
            return result;
        }
    }
}