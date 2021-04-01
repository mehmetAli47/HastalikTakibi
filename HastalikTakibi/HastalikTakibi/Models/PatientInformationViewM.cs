using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastalikTakibi.Models
{
    public class PatientInformationViewM
    {
        public int Id { get; set; }
        public int PatientId { get; set; }    
        public int DiseaseId { get; set; }       
        public DateTime? WhenIll { get; set; }
        public DateTime? RecoveryTime { get; set; }
        public string Symptoms { get; set; }
        public string DiseaseName { get; set; }
        public string ProvinceName { get; set; }
        public string DistrictName { get; set; }
        public string PatientName { get; set; }
    }
}
