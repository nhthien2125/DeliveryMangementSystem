using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DeliveryMangementSystem.Models
{
    public enum UserRole
    {
        Admin,
        Shipper
    }

    [Table ("Account")]
    public class ACCOUNT
    {
        [Key]
        [StringLength (10)]
        [Column ("Account_ID")]
        public string Id { get; set; }

        [StringLength (50)]
        [Column ("Username")]
        [Required]
        public string Username { get; set; }

        [StringLength (50)]
        [Column ("Password")]
        [Required]
        public string Password { get; set; }
        [Required]
        public UserRole Role { get; set; }

        public virtual SHIPPER Shipper { get; set; }
    }
}

//done