using Microsoft.EntityFrameworkCore;

namespace justtest.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext (DbContextOptions<ModelContext> options) : base(options)
        {

        }

        public DbSet<justtest.Models.Movie> Movie {get;set;}
    }
}