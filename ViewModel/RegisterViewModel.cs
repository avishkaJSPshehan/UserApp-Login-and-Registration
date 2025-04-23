using System;
using System.ComponentModel.DataAnnotations;

namespace UserApp_Login_and_Registration.ViewModel;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Name is Required.")]
    public string Name { get; set; }


    [Required(ErrorMessage = "Email is Required.")]
    [EmailAddress]
    public string Email { get; set; }


    [Required(ErrorMessage = "Password is Required.")]
    [StringLength(40, MinimumLength = 8, ErrorMessage = "Password Required Minimum 8 Caracters.")]
    [DataType(DataType.Password)]
    [Compare("ConfirmPassword", ErrorMessage = "Password does not match.")]
    public string Password { get; set; }


    [Required(ErrorMessage = "Confirm Password is Required.")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password.")]
    public string ConfirmPassword { get; set; }
}
