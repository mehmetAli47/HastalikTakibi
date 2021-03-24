using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HastalikTakibi.DAL.Models.Database
{
    [Table("category")]
    public class Category : BaseTable
    {
        [Column("category_name")]
        public string Name { get; set; }
       
    }
}
