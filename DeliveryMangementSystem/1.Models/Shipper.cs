using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryMangementSystem.Models
{   
    public class SHIPPER
    {
        public string Shipper_ID { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<ORDER> Orders { get; set; } = new List<ORDER>();
    }
}

//done