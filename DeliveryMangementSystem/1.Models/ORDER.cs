using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryMangementSystem.Models
{
    public enum OrderStatus
    {
        Pending,
        Shipping,
        Delivered,
        Cancelled
    }
    public enum PaymentMethod
    {
        Cash,
        BankTransfer,
    }
     
    public class ORDER
    {
        public string Order_ID { get; set; }
        public string Branch_ID { get; set; }
        public string Customer_ID { get; set; }
        public string Shipper_ID { get; set; }


        public OrderStatus Status { get; set;}
        public PaymentMethod Payment_Method { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime? Delivery_Date { get; set; }
        public decimal Total_Amount { get; set; }


        public virtual BRANCH Branch { get; set; }
        public virtual CUSTOMER Customer { get; set; }
        public virtual SHIPPER Shipper { get; set; } 
    }
}
