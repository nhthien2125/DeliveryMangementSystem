using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeliveryMangementSystem.Models
{
    public class BRANCH
    {
        public string Branch_ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        

        public virtual ICollection<ORDER> Orders { get; set; } = new List<ORDER>();
    }
}
