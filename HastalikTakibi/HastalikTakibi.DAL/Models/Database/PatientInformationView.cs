using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HastalikTakibi.DAL.Models.Database
{
    public class PatientInformationView : patientInformationBase
    {
        [Column("disease_name")]
        public string DiseaseName { get; set; }
        [Column("province_name")]
        public string ProvinceName { get; set; }
        [Column("district_name")]
        public string DistrictName { get; set; }
        [Column("name")]
        public string PatientName { get; set; }
    }
}
