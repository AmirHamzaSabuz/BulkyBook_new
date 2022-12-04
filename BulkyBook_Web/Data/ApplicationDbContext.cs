using BulkyBook_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook_Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
