using APIContactList.Server.Areas.Identity.Data;
using APIContactList.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIContactList.Server.Data;

public class APIContactListServerContext : IdentityDbContext<APIContactListServerUser>
{
    public DbSet<Customer> Customers { get; set; }   
    public APIContactListServerContext(DbContextOptions<APIContactListServerContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<APIContactList.Server.Models.Company> Company { get; set; } = default!;
}
