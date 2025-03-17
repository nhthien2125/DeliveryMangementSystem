using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryMangementSystem.Models
{
    [Table("BRANCH")]
    public class BRANCH
    {
        [Key]
        [StringLength(10)]
        [Column("Branch_ID")]
        public string ID { get; set; }

        [StringLength(100)]
        [Column("Name")]
        public string Name { get; set; }

        [StringLength(100)]
        [Column("Address")]
        public string Address { get; set; }

        public virtual ICollection<xORDER> Orders { get; set; }
    }
}
