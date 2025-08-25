using System;
using Microsoft.AspNetCore.Identity;
namespace ProjectWebApp.Models;

    public class User : IdentityUser
{
public User()
    { public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastLoginAt { get; set; }
    public bool IsActive { get; set; } = true;
}
}