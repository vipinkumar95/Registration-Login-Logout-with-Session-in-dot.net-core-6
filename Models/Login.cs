using System.ComponentModel.DataAnnotations;

namespace Loginwithsession.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
    }
}
