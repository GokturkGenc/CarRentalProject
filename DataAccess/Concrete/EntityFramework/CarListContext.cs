using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{

    public class CarListContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=desktop-avho68b\sqlexpress1 ; Database=CarDatabase ; Trusted_Connection=True");
        }

        public DbSet<Car> Tbl_Cars { get; set; }
        public DbSet<Color> Tbl_Colors { get; set; }
        public DbSet<Brand> Tbl_Brands { get; set; }
        public DbSet<Rental> Tbl_Rents { get; set; }
        public DbSet<Customer> Tbl_Customers { get; set; }
        public DbSet<User> Tbl_Users { get; set; }
        public DbSet<CarImage> Tbl_CarImages { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> Tbl_OperationClaims { get; set; }  
    }
}