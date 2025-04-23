using System;
using Microsoft.AspNetCore.Identity;

namespace UserApp_Login_and_Registration.Models;

public class Users : IdentityUser
{
    public string FullName { get; set; }
}
