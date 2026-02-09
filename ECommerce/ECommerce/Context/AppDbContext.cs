
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
        public DbSet<Product> Product { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        


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

            modelBuilder.Entity<Product>(b =>
            {
                b.HasKey("ProductId"); /*PK*/
                b.Property("ProductId").ValueGeneratedOnAdd(); /*Identity*/
                b.Property("Price").HasColumnType("decimal(10,2)");
                /*Relación Con Fk*/
                b.HasOne(b => b.Category).WithMany(p => p.Products).HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Restrict); /*ImpedirElBorrado*/
            });


            modelBuilder.Entity<User>(c =>
            {
                c.HasKey("UserId");
                c.Property("UserId").ValueGeneratedOnAdd();
            });


            modelBuilder.Entity<Order>(d =>
            {
                d.HasKey("OrderId");
                d.Property("OrderId").ValueGeneratedOnAdd();
                d.Property("TotalAmount").HasColumnType("decimal(10,2)");
                /*Relación Con Fk*/
                d.HasOne(d => d.User).WithMany(p => p.Orders).HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<OrderItem>(e =>
            {
                e.HasKey("OrderItemId");
                e.Property("OrderItemId").ValueGeneratedOnAdd();
                e.Property("Price").HasColumnType("decimal(10,2)");
                /*Relación Con Fk*/
                e.HasOne(e => e.Order).WithMany(p => p.OrderItems).HasForeignKey(e => e.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
                
                e.HasOne(e => e.Product).WithMany().HasForeignKey(e => e.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            });


        }/*OnModelCreating*/




    }
}

    
