using AuthenticationAndAuthorization.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationAndAuthorization.Models.DTOs
{
    public class UserUpdateDTO
    {

        [Required(ErrorMessage = "Username is a must!")]
        [Display(Name = "User Name")]
        [MinLength(2, ErrorMessage = "Username has to have at least 2 characters!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is a must!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is a must!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is unvalid!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public UserUpdateDTO()
        {

        }

        public UserUpdateDTO(AppUser user)
        {
            Username = user.UserName;
            Password = user.PasswordHash;
            Email = user.Email;
        }

    }
}
