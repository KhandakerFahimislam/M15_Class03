using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Class03.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required,StringLength(100)]
        public string Name { get; set; } = default!;
        [Required,Column(TypeName ="money")]
        public decimal Price { get; set; }
        [Required, StringLength(100)]

        public string Picture { get; set; } = default!;

    }
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options) { }
        
        public DbSet<Product> Products { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string[] ProductNames = new string[] { "Nokia", "Vivo", "Oppo" };
            decimal[] Prices = new decimal[] { 20000.00M, 150000.00M, 170000.00M };
            for (var i = 0; i < ProductNames.Length; i++)
            {
                modelBuilder.Entity<Product>().HasData(new Product
                {
                    Id = i + 1,
                    Name = ProductNames[i],
                    Price = Prices[i],
                    Picture = $"{i}.jpg"
                });
                
            }
        }
    }
}
