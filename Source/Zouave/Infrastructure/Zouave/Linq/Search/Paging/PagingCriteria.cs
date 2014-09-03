namespace Zouave.Linq.Search.Paging
{
    public class PagingCriteria
    {
        public PagingCriteria(int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}