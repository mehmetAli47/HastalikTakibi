using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HastalikTakibi.DAL.Models.Database
{
    [Table("province")]
    public class Province
    {
        [Key]
        [Column("plate_number")]
        public int ProvinceNumber { get; set; }
        [Column("province_name")]
        public string ProvinceName{ get; set; }

       
    }
}
