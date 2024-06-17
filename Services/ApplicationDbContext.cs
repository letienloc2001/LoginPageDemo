using Microsoft.EntityFrameworkCore;

namespace LoginPageDemo;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options) 
    {
        
    }
}
