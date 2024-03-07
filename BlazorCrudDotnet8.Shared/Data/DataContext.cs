using BlazorCrudDotnet8.Shared.Entities;
using Microsoft.EntityFrameworkCore;

// model for database connection

namespace BlazorCrudDotnet8.Shared.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
    }
}
