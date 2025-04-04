using System.Collections.Generic;

namespace DeliveryMangementSystem.Models
{
    public class Branch
    {
        public string Branch_ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
