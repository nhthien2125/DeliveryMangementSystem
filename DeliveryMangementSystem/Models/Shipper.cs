using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbShipper.Models
{   
    [Table ("SHIPPER")]
    public class Shipper
    {
        [Key]
        [StringLength (10)]
        [Column ("Shipper_ID")]
        public String ID { get; set; }
        [StringLength (10)]
        [Column ("Phone")] 
        public String Phone { get; set; }
        [StringLength (100)]
        [Column ("Name")]
        public String Name { get; set; }

    }
}
