using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryMangementSystem.Models
{   
    [Table ("SHIPPER")]
    public class SHIPPER
    {
        [Key]
        [StringLength (10)]
        [Column ("Shipper_ID")]
        public string Id { get; set; }
        [StringLength (10)]
        [Column ("Phone")] 
        public string Phone { get; set; }

        [StringLength (100)]
        [Column ("Name")]
        public string Name { get; set; }

        [StringLength (100)]
        [Column("Email")]
        public string Email { get; set; }
        public virtual ICollection<xORDER> Orders { get; set; } = new List<xORDER>();
    }
}

//done