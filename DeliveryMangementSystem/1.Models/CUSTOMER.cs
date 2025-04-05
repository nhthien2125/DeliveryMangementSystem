using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DeliveryMangementSystem.Models
{
    public class CUSTOMER
    {
        public string Customer_ID { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        

        public virtual ICollection<ORDER> Orders { get; set; } = new List<ORDER>();
    }
}
