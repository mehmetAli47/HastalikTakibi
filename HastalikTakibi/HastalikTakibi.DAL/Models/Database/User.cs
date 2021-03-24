using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HastalikTakibi.DAL.Models.Database
{       
      [Table("user")]
      public class User:BaseTable
    {
        [Column("name")]
        public string name { get; set; }

        [Column("surname")]
        public string surname { get; set; }

        [Column("mail")]
        public string mail { get; set; }

        [Column("user_name")]
        public string username { get; set; }

        [Column("password")]
        public string password { get; set; }

    }
}
