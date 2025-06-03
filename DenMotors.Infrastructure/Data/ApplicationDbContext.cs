using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DenMotors.Web.Data;

namespace DenMotors.Web.Data;

/// <summary>
/// Application database context for Identity.
/// </summary>
/// <param name="options">The options for this context.</param>
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<CarMake> CarMakes { get; set; }
    public DbSet<CarModel> CarModels { get; set; }
    public DbSet<CarStatus> CarStatuses { get; set; }
    public DbSet<Car> Cars { get; set; }
}
