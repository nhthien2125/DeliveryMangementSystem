using System.Collections.Generic;

namespace DeliveryMangementSystem.Models
{     
    public class Shipper
    {
        public string Shipper_ID { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual Account Account { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}