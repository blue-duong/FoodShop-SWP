﻿using System;
using System.Collections.Generic;
using FoodShop_SWP.Models.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FoodShop_SWP.Models
{
    public partial class ShopFoodWebContext : DbContext
    {
        public ShopFoodWebContext() { }
        public ShopFoodWebContext(DbContextOptions<ShopFoodWebContext> options) : base(options) {
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;

        public DbSet<Adv> Advs { get; set; } = null!; 
        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<News> News { get; set; } = null!;
        public DbSet<SystemSetting> SystemSettings { get; set; } = null!;
        public DbSet<Posts> Posts { get; set; } = null!;
        public DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<Subscribe> Subscribes {  get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-IL9OFDR\\MAYAO;Database=FoodShopWeb;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
            
        }
    }
}
