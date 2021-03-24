using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastalikTakibi.Models
{
    public class PatientVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public long TC { get; set; }
        public long Phone { get; set; }
        public string Province { get; set; }
        public string District { get; set; }

        public List<int> CategoryIdList { get; set; }
        public List<int> DiseaseIdList { get; set; }
    }
}
