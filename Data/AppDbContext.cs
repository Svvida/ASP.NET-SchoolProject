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
        public DbSet<EmploymentHistoryEntity> EmploymentHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source =C:\Users\ksvvi\source\repos\ASP.NET-SchoolProject\employees.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string ADMIN_ID = Guid.NewGuid().ToString();
            string USER_ID = Guid.NewGuid().ToString();

            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                               new IdentityRole
                               {
                                Id = ADMIN_ROLE_ID,
                                Name = "admin",
                                NormalizedName = "admin",
                                ConcurrencyStamp = ADMIN_ROLE_ID
                                },
                                new IdentityRole
                                {
                                Id = USER_ROLE_ID,
                                Name = "User",
                                NormalizedName = "USER",
                                ConcurrencyStamp = USER_ROLE_ID
                                });

            var admin = new IdentityUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@wsei.edu.pl",
                NormalizedEmail = "ADMIN@WSEI.EDU.PL",
                EmailConfirmed = true,
            };
            var user = new IdentityUser
            {
                Id = USER_ID,
                UserName = "user",
                NormalizedUserName = "user",
                Email = "user@wsei.edu.pl",
                NormalizedEmail = "USER@WSEI.EDU.PL",
                EmailConfirmed = true,
            };

            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = ph.HashPassword(admin, "P@ssw0rd");
            user.PasswordHash = ph.HashPassword(user, "P@ssw0rd");

            modelBuilder.Entity<IdentityUser>().HasData(admin, user);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                               new IdentityUserRole<string>
                               {
                                RoleId = ADMIN_ROLE_ID,
                                UserId = ADMIN_ID
                                },
                                new IdentityUserRole<string>
                                {
                                RoleId = USER_ROLE_ID,
                                UserId = USER_ID
                                });

            modelBuilder.Entity<EmployerEntity>()
                .HasMany(e => e.Employees)
                .WithOne(e => e.Employer)
                .HasForeignKey(e => e.EmployerId);
            modelBuilder.Entity<EmployeeEntity>()
                .HasMany(e => e.EmploymentHistory)
                .WithOne(eh => eh.Employee)
                .HasForeignKey(eh => eh.EmployeeId);


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
