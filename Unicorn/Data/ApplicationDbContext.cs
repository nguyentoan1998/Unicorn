
namespace Unicorn.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CV> CV { get; set; }
        public DbSet<KH> KH { get; set; }
        public DbSet<NCC> NCC { get; set; }
        public DbSet<NV> NV { get; set; }
        public DbSet<To> To { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Quyen> Quyen { get; set; }
    }
}