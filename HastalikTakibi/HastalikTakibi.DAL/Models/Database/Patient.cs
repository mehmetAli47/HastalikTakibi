using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HastalikTakibi.DAL.Models.Database
{
    [Table("patient")]
    public class Patient:BaseTable
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("surname")]
        public string Surname { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("e-mail")]
        public string EMail { get; set; }
        [Column("tc")]
        public long TC { get; set; }
        [Column("phone")]
        public long Phone { get; set; }
        [Column("province")]
        public string Province { get; set; }
        [Column("district")]
        public string District { get; set; }

       
    }

}
