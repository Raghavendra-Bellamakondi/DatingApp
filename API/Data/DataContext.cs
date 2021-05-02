using Dating_API.DataEntities;
using Microsoft.EntityFrameworkCore;

namespace Dating_API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<AppUser> Users { get; set; }
        
        
    }
}