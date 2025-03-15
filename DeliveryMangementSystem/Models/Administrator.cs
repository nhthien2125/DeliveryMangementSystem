using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Administrator.Models
{
    [Table ("ADMINISTRATOR")]
    class Administrator
    {
        [Key]
        [StringLength (10)]
        [Column ("Admin_ID")]
        public string Id { get; set; }

        [StringLength (50)]
        [Column ("Username")]
        [Required]
        public string Username { get; set; }

        [StringLength (50)]
        [Column ("Password")]
        [Required]
        public string Password { get; set; }
    }
}

//done