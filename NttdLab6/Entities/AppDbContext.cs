using Microsoft.EntityFrameworkCore;
using NttdLab6.Models;

namespace NttdLab6.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Thêm đoạn này để khi chạy lệnh migration/update-database nó tự nhận luôn connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(local)\\SQLEXPRESS01;Database=NttdCRUD;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}