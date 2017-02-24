namespace ASD.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class store : DbContext
    {
        public store()
            : base("name=store")
        { }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCart { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Customer_Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Customer_Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Customer_Cell)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Customer_Home)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Customer_Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Customer_State)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Customer_Zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Wholesaler_Cost)
                .HasPrecision(19, 2);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Min_Price)
                .HasPrecision(19, 2);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Max_Price)
                .HasPrecision(19, 2);
        }
    }
}
