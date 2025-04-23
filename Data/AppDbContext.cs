using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserApp_Login_and_Registration.Models;

namespace UserApp_Login_and_Registration.Data;

public class AppDbContext : IdentityDbContext<Users>
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected AppDbContext()
    {
    }
}
