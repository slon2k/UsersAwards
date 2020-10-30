using App.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<User>().HasData(
                new User(){ FirstName = "Bill", LastName = "Gates", BirthDate = new DateTime(1958, 10, 28), Id = 1 },
                new User(){ FirstName = "Severus", LastName = "Snape", BirthDate = new DateTime(1960, 01, 09), Id = 2 },
                new User(){ FirstName = "Arthur", LastName = "Weasley", BirthDate = new DateTime(1965, 02, 06), Id = 3 },
                new User(){ FirstName = "Draco", LastName = "Malfoy", BirthDate = new DateTime(1980, 06, 13), Id = 4 },
                new User(){ FirstName = "Ginny", LastName = "Weasley", BirthDate = new DateTime(1980, 08, 11), Id = 5 }

                );
            modelBuilder.Entity<Award>().HasData(
                new Award() { Title = "MVP", Description = "Microsoft Most Valuable Professional", Id = 1 },
                new Award() { Title = "MCAD", Description = "Microsoft Certified Application Developer", Id = 2 },
                new Award() { Title = "MCSD", Description = "Microsoft Certified Solution Developer", Id = 3 },
                new Award() { Title = "MCSE", Description = "Microsoft Certified Systems Engineer", Id = 4 },
                new Award() { Title = "MCDBA", Description = "Microsoft Certified Database Administrator", Id = 5 },
                new Award() { Title = "MCITP", Description = "Microsoft Certified IT Professional", Id = 6 }
                );
        }
    }
}
