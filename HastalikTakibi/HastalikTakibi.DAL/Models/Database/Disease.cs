using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HastalikTakibi.DAL.Models.Database
{
    [Table("disease")]
    public class Disease: DiseaseBase
    {
        public IList<DiseaseCategory> DiseaseCategory { get; set; }

    }

    public class DiseaseBase:BaseTable
    {
        [Column("disease_name")]
        public string Name { get; set; }
        [Column("first_seen_date")]
        public DateTime? FirstSeenDate { get; set; }
    }
}
