using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DenMotors.Web.Data;

/// <summary>  
/// Represents an application user in the DenMotors system.  
/// Inherits from <see cref="IdentityUser"/> to provide identity-related properties and methods.  
/// </summary>  
public class ApplicationUser : IdentityUser
{
    /// <summary>
    /// Gets or sets the user's first name.
    /// </summary>
    [PersonalData]
    [StringLength(100)]
    public string FirstName { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the user's last name.
    /// </summary>
    [PersonalData]
    [StringLength(100)]
    public string LastName { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the user's job title at the dealership.
    /// </summary>
    [StringLength(100)]
    public string JobTitle { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets the user's full name, combining first and last names.
    /// </summary>
    public string FullName => $"{FirstName} {LastName}".Trim();
    
    /// <summary>
    /// Gets or sets the date when the user was created.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    /// <summary>
    /// Gets or sets the date when the user was last active.
    /// </summary>
    public DateTime? LastActive { get; set; }
}

