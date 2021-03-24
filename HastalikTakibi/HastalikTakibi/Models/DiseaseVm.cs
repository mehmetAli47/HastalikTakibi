using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastalikTakibi.Models
{
    public class DiseaseVm
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime? FirstSeenDate { get; set; }

        public List<int> CategoryIdList { get; set; }

        public virtual CategoryVM Category { get; set; }
    }
}
