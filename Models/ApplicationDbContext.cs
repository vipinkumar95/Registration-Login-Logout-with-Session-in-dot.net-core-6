using Microsoft.EntityFrameworkCore;

namespace Loginwithsession.Models
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
       { }
        
        public DbSet<Login> Logins { get; set; }
    }
}
