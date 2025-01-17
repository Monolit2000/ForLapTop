﻿using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<CartItem> CartItems { get; set; } = null!;
        public DbSet<AnonymousUser> AnonymousUsers { get; set; } = null!;
        public DbSet<ShoppingCart> ShoppingCartItems { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options) 
        {

           //Database.EnsureDeleted();
           Database.EnsureCreated();
           
            
        }


        public ApplicationContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<AnonymousUser>()
            //.HasMany(b => b.CartItemsId).HasNoKey();
            ////.WithOne();

            //modelBuilder.Entity<User>().HasAlternateKey(u => u.CookiId);
            // modelBuilder.Entity<User>().HasKey(u => u.CookiId);
        }
    }
}
