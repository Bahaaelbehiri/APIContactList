using Microsoft.EntityFrameworkCore;

namespace APIContactList.Server.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<ICustomFormatter> Customers { get; set; } 
    }
}
