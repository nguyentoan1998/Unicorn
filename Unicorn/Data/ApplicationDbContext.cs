
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
        public DbSet<DMNVL> DMNVL { get; set; }
        public DbSet<DVCD> DVCD { get; set; }
        public DbSet<NVL> NVL { get; set; }
        public DbSet<DVT> DVT { get; set; }
        public DbSet<MQC> MQC { get; set; }
        public DbSet<Loai> Loai { get; set; }
        public DbSet<Quyen> Quyen { get; set; }
    }
}