using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HastalikTakibi.DAL.Models.Database
{
    [Table("patient_information")]
    public class PatientInformation:patientInformationBase
    {
        [Column("category_id")]
        public int CategoryId { get; set; }
        [Column("province_id")]
        public int? ProvinceId { get; set; }
        [Column("district_id")]
        public int? DistrictId { get; set; }

        [Column("latitude")]
        public double? Latitude { get; set; }
        [Column("longitude")]
        public double? Longitude { get; set; }

    }

    public class patientInformationBase



    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("patient_id")]
        public int PatientId { get; set; }
        [Column("disease_id")]
        public int DiseaseId { get; set; }
        [Column("when_ill")]
        public DateTime? WhenIll { get; set; }
        [Column("recovery_time")]
        public DateTime? RecoveryTime { get; set; }
        [Column("symptoms")]
        public string Symptoms { get; set; }
    }
}
