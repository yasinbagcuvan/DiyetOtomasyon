using ANK16ProductApplication.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16ProductApplication.DAL.Context
{
    public class ProductDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GANK-EGT-0501WC\\SQLEXPRESS; Database=ANK16ProductDb;Trusted_Connection=true;trustservercertificate=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }


    }
}
