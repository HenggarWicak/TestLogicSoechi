using _10112022_Soechi.Models;
using Microsoft.EntityFrameworkCore;

namespace _10112022_Soechi.Data
{
    public class SoechiContext : DbContext
    {
        public SoechiContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UomModel> UOM { get; set; }
    }
}
