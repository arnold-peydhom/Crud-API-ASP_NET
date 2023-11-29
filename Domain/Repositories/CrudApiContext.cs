using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repositories
{
    public class CrudApiContext : DbContext
    {
        public CrudApiContext() { }
        public CrudApiContext(DbContextOptions<CrudApiContext> options) : base(options){ }

        public DbSet<User> User { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               "Data Source =DESKTOP-ARNOLD-\\SQLEXPRESS;Initial Catalog = CrudAPI");
        }
    }
}
