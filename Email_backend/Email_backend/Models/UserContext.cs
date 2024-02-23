using Microsoft.EntityFrameworkCore;

namespace Email_backend.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Registration> Users { get; set; }
    }
}
