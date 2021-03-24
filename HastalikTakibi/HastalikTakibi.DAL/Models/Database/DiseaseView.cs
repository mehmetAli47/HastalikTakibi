using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HastalikTakibi.DAL.Models.Database
{
    public class DiseaseView : DiseaseBase
    {
        [Column("category_string")]
        public string Category { get; set; }

        
    }
}
