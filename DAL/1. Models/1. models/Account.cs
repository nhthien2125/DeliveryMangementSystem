namespace DeliveryMangementSystem.Models
{
    public enum UserRole
    {
        Admin,
        Shipper
    }

    public class Account
    {
        public string Account_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public string Shipper_Id { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}