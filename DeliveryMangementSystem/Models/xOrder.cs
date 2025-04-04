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

    [Table("xORDER")]
    public class xORDER
    {
        [Key]
        [StringLength(10)]
        [Column("Order_ID")]public string Id { get; set; }
        

        [Required]
        [StringLength(10)]
        [Column("Branch_ID")]public string BranchId { get; set; }
        [ForeignKey("BranchId")]
        public virtual BRANCH Branch { get; set; }


        [Required]
        [StringLength(10)]
        [Column("Customer_ID")]public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual CUSTOMER Customer { get; set; }


        [Required]
        [StringLength(10)]
        [Column("Shipper_ID")]public string ShipperId { get; set; }
        [ForeignKey("ShipperId")]
        public virtual SHIPPER Shipper { get; set; }


        [Required]
        [Column("Order_Date")]public System.DateTime OrderDate { get; set; }
        

        [Column("Delivery_Date")]public System.DateTime? DeliveryDate { get; set; }
        

        [Column("Total_Amount")]public decimal TotalAmount { get; set; }
        

        [Required]
        [Column("Status")]public OrderStatus Status { get; set;}


        [Required]
        [Column("Payment_Method")]public PaymentMethod PaymentMethod { get; set; }
    }
}
