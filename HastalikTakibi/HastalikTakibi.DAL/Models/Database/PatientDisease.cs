using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HastalikTakibi.DAL.Models.Database
{
    [Table("patient_disease")]
   public class PatientDisease
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("disease_id")]
        public int DiseaseId { get; set; }
        [Column("patient_id")]
        public int PatientId { get; set; }
        [Column("disease_name")]
        public String Name { get; set; }
        [Column("time_sick")]
        public DateTime TimeSick { get; set; }
        [Column("recovery_time")]
        public DateTime? RecoveryTime { get; set; }
        [Column("symptoms")]
        public string Symptoms { get; set; }
        [Column("sick_place")]
        public string SickPlace { get; set; }


    }
}
