using System;
using System.ComponentModel.DataAnnotations;

namespace UserApp_Login_and_Registration.ViewModel;

public class LoginViewModel
{
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "Remember Me?")]
    public bool RememberMe { get; set; }
}
