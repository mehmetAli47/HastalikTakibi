using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastalikTakibi.Models
{
    public class GridResponseVM<T>
    {
        public int Page { get; set; }

        public int TotalCount { get; set; }

        public List<T> ObjList { get; set; }
    }
}
