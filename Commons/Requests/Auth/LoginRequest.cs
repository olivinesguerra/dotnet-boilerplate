using System.ComponentModel.DataAnnotations;

namespace net_core_example.Commons.Request.Auth {
    public class LoginRequest
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}

