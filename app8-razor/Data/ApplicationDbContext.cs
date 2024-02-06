using app8_razor.Models;
using Microsoft.EntityFrameworkCore;

namespace app8_razor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) { }
        public DbSet<Article> Articles { get; set; }
    }
}
