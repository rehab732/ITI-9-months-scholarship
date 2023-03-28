using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace Day3.DTO
{
    public class RegisterUserDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }

    }
}
