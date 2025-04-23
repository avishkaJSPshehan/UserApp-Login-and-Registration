using System;
using System.ComponentModel.DataAnnotations;

namespace UserApp_Login_and_Registration.ViewModel;

public class ChangePasswordViewModel
{
    [Required(ErrorMessage = "Email is Required.")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is Required.")]
    [StringLength(40, MinimumLength = 8, ErrorMessage = "Password Required Minimum 8 Caracters.")]
    [DataType(DataType.Password)]
    [Display(Name ="New Password")]
    [Compare("ConfirmNewPassword", ErrorMessage = "Password does not match.")]
    public string NewPassword { get; set; }


    [Required(ErrorMessage = "Confirm New Password is Required.")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm New Password.")]
    public string ConfirmNewPassword { get; set; }
}
