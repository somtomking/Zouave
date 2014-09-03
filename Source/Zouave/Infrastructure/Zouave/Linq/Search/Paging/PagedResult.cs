using System.Collections.Generic;

namespace Zouave.Linq.Search.Paging
{
    public class PagedResult<TEntity>
    {
        public PagedResult(int count, IEnumerable<TEntity> entities)
        {
            Count = count;
            Entities = entities;
        }

        public int Count { get; set; }
        public IEnumerable<TEntity> Entities { get; set; }
    }
}