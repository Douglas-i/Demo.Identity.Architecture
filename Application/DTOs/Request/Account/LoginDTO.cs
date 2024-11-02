using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Request.Account
{
    public class LoginDTO
    {
        [EmailAddress, Required]
        [RegularExpression("[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+",
            ErrorMessage ="Your Email is not valid, provide valid email such as..")]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",
            ErrorMessage = "Your password must be a mix of Alphanumrci and special characters")]
        public string Password { get; set; } = string.Empty;
    }
}
