using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
namespace Ecommerce.DAL.ViewModel
{
    /// <summary>
    /// Represents the view model for user-related data in the application.
    /// </summary>
    public class UserViewModel
    {
        [Required(ErrorMessage = "Please enter your full name.")]
        [StringLength(50, ErrorMessage = "Full name must be between {2} and {1} characters long.", MinimumLength = 3)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter an email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(20, ErrorMessage = "Username must be between {2} and {1} characters long.", MinimumLength = 3)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(20, ErrorMessage = "The password must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required()]
        public bool Agree { get; set; }


    }
}
