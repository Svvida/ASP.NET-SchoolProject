using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<EmployerEntity> Employers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source =C:\Users\ksvvi\source\repos\ASP.NET-SchoolProject\employees.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string ADMIN_ID = Guid.NewGuid().ToString();
            modelBuilder.Entity<EmployeeEntity>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<EmployeeEntity>()
                .HasData(
                                   new EmployeeEntity
                                   {
                        Id = 1,
                        FirstName = "Jan",
                        LastName = "Kowalski",
                        PESEL = "12345678901",
                        Position = "Programista",
                        Department = "IT",
                        EmploymentDate = new DateTime(2010, 1, 1),
                        EmployerId = null
                    },
                                                      new EmployeeEntity
                                                      {
                        Id = 2,
                        FirstName = "Anna",
                        LastName = "Nowak",
                        PESEL = "12345678902",
                        Position = "Kierownik",
                        Department = "Administracja",
                        EmploymentDate = new DateTime(2015, 1, 1),
                        EmployerId = null
                    }
                                                                    );
        }
    }
}
