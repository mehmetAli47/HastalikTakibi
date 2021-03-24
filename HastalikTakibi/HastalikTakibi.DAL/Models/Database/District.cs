using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HastalikTakibi.DAL.Models.Database
{
    [Table("district")]
     public class District
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("district_name")]
        public string DistrictName { get; set; }

        [ForeignKey("province")]
        [Column("plate_number")]
        public int PlateNumber { get; set; }

        
    }
}
