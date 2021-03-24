using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HastalikTakibi.DAL.Models.Database
{
    [Table("disease_category")]
    public class DiseaseCategory :BaseTable
    {
        [Column("disease_id")]
        public int DisaeaseId { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }


        public  Disease Disease { get; set; }
    }
}
