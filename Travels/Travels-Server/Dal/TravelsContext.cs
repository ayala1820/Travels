using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Dal
{
    public class TravelsContext:DbContext
    {
        private readonly IConfiguration _configuration;
        //public TravelsContext()
        //{

        //}
        public TravelsContext(DbContextOptions<TravelsContext> options,IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<Activity> Activities { get; set; }
        //public DbSet<Image> Images { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL(_configuration.GetConnectionString("DefaultConnection"));
        //=> optionsBuilder.UseSqlServer("Server=NANKENSKI\\SQLEXPRESS;Database=travels;Trusted_Connection=True;TrustServerCertificate=True");

    }
}
