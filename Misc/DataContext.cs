using Microsoft.EntityFrameworkCore;
using ngx_backend.Entities;

namespace ngx_backend.Misc
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}