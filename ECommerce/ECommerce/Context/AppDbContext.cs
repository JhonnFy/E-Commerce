
using Microsoft.EntityFrameworkCore; /*Paquetes*/
using ECommerce.Entities; /*Proyecto Folder*/


namespace ECommerce.Context
{
    public class AppDbContext : DbContext /*Heredar de DbContext*/
    {
        /*Constructor*/
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        /*Estructura De Las Tablas*/
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<User> User { get; set; }


        /*Modelado Tabla Category*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>(a =>
            {
                a.HasKey("CategoryId"); /*PK*/
                a.Property("CategoryId").ValueGeneratedOnAdd(); /*Identity*/
                a.HasData(
                    new Category {CategoryId = 1, Name = "Technology" },
                    new Category {CategoryId = 2, Name = "Bedroom" }
                    );
            });
        }




    }
}

    
