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
    public class Order
    {
        public string Order_ID { get; set; }
        public string Branch_ID { get; set; }       
        public string Customer_ID { get; set; }
        public string Shipper_ID { get; set; }
        public System.DateTime Order_Date { get; set; }
        public System.DateTime? Delivery_Date { get; set; }
        public decimal Total_Amount { get; set; }
        public OrderStatus Status { get; set; }
        public PaymentMethod Payment_Method { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}