using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DeliveryMangementSystem.Models
{
    [Table("CUSTOMER")]
    public class CUSTOMER
    {
        [Key]
        [StringLength(10)]
        [Column("Customer_ID")]
        public string ID { get; set; }

        [StringLength(10)]
        [Column("Phone")]
        public string Phone { get; set; }

        [StringLength(100)]
        [Column("Name")]
        public string Name { get; set; }

        [StringLength(100)]
        [Column("Address")]
        public string Address { get; set; }

        public virtual ICollection<xORDER> Orders { get; set; } = new List<xORDER>();
    }
}
