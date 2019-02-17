using Microsoft.EntityFrameworkCore;
using SunflowerFund.API.models;

namespace SunflowerFund.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base (options) {}

        public DbSet<Medical> MedicalsScreening { get; set;}
        public DbSet <User> Users { get; set; }
    }
} 