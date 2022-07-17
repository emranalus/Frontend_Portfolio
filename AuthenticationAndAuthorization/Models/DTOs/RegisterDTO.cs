using System.ComponentModel.DataAnnotations;

namespace AuthenticationAndAuthorization.Models.DTOs
{
    public class RegisterDTO
    {

        [Required(ErrorMessage = "Username is a must!")]
        [Display(Name = "User Name")]
        [MinLength(2, ErrorMessage = "Username must countain at least 2 characters...")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is a must!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Unvalid Emal Address...")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is a must!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "TC Kimlik No")]
        public string TcNo { get; set; }

    }
}
