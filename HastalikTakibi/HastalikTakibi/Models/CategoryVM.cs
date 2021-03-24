using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastalikTakibi.Models
{
    public class CategoryVM
    {
        public CategoryVM()
        {
            Disease = new List<DiseaseVm>();
        }
        public int ID { get; set; }
         public string Name { get; set; }

        public virtual List<DiseaseVm> Disease { get; set; }
    }
}
