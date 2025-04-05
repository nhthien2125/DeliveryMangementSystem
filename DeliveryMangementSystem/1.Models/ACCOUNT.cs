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
        Inactive,
        Active
    }
    public class ACCOUNT
    {
        public string Account_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public UserStatus Status { get; set; }
        public string S_ID { get; set; }
        public virtual SHIPPER Shipper { get; set; }
    }
}

//done