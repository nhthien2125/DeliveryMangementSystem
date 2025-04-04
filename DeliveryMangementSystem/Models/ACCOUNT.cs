using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryMangementSystem.Models
{
    public enum UserRole
    {
        Admin,
        Shipper
    }
    public enum UserStatus
    {
        Active,
        Inactive
    }

    [Table ("Account")]
    public class ACCOUNT
    {
        [Key]
        [StringLength (10)]
        [Column ("Account_ID")]public string Id { get; set; }
        

        [StringLength (50)]
        [Required]
        [Column ("Username")]public string Username { get; set; }
        

        [StringLength (50)]
        [Required]
        [Column ("Password")]public string Password { get; set; }
        

        [Required]
        [Column("Role")]public UserRole Role { get; set; }
        

        [Required]
        [Column("Status")]public UserStatus Status { get; set; }
        

        [StringLength(10)]
        [Column("Shipper_ID")]public string ShipperId { get; set; }
        [ForeignKey("ShipperId")]


        public virtual SHIPPER Shipper { get; set; }
    }
}

//done