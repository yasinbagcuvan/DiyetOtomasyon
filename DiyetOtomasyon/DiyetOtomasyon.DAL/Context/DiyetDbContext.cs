using DiyetOtomasyon.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.DAL.Context
{
    public class DiyetDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SDLI8OI\\SQLEXPRESS; Database=DiyetDB1;Trusted_Connection=true;trustservercertificate=true");
            optionsBuilder.UseLazyLoadingProxies(true);
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<PersonMeal> PersonMeals { get; set; }
        public DbSet<MealTime> MealTimes { get; set; } 
        public DbSet<Portion> Portions { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersonMeal>().Ignore(pm => pm.Id);
            modelBuilder.Entity<PersonMeal>().HasKey(pm => new {pm.PersonId, pm.MealId, pm.CreatedDate });
        }
    }
}
