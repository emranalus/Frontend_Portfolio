using System.ComponentModel.DataAnnotations;

namespace AuthenticationAndAuthorization.Models.DTOs
{
    public class LoginDTO
    {

        [Required(ErrorMessage = "Username is a must!")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is a must!")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        //public string ReturnUrl { get; set; }

    }
}
