using Core.Entities.Concrate;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    //Context:Db ile yani sql tabloları ile class ları bagalamak
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<CategoryBrand> CategoriesBrands{ get; set; }
        public DbSet<District> districts { get; set; }
        public DbSet<ProductImage> ProductImage{ get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<UserFavorite> favorites { get; set; }
        public DbSet<SideCategory> SideCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UnderCategory> UnderCategories { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
