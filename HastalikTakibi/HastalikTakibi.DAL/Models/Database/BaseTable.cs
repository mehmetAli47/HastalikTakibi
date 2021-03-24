using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HastalikTakibi.DAL.Models.Database
{
    public class BaseTable
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("create_time")]
        public DateTime CreateTime { get; set; }
        [Column("last_update_time")]
        public DateTime? LastUpdateTime { get; set; }

    }
}
