using System.Collections.Generic;

namespace Department.Base.Model.Common
{
    public class GenericSearchResult<T>
    {
        public GenericSearchResult()
        {
            Results = new List<T>();
        }

        public int TotalCount { get; set; }
        public ICollection<T> Results { get; set; }
    }
}
