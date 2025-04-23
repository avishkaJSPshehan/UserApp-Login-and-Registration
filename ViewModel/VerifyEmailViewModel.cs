using System;
using System.ComponentModel.DataAnnotations;

namespace UserApp_Login_and_Registration.ViewModel;

public class VerifyEmailViewModel
{
    [Required(ErrorMessage = "Email is Required.")]
    [EmailAddress]
    public string Email { get; set; }
}
