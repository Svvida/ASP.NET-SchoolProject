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
        public DbSet<AddressEntity> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source =..\employees.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string ADMIN_ID = Guid.NewGuid().ToString();
            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ADMIN_ROLE_ID,
                Name = "Admin",
                NormalizedName = "Admin".ToUpper(),
                ConcurrencyStamp = ADMIN_ROLE_ID,
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = USER_ROLE_ID,
                Name = "User",
                NormalizedName = "User".ToUpper(),
                ConcurrencyStamp = USER_ROLE_ID,
            });

            var admin = new IdentityUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin".ToUpper(),
                Email = "admin@wsei.edu.pl",
                NormalizedEmail = "ADMIN@WSEI.EDU.PL"
            };
            var user = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "user",
                NormalizedUserName = "user".ToUpper(),
                Email = ""
            };
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = ph.HashPassword(admin, "P@ssword1");
            user.PasswordHash = ph.HashPassword(user, "P@ssword1");
            modelBuilder.Entity<IdentityUser>().HasData(user);
            modelBuilder.Entity<IdentityUser>().HasData(admin);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_ID
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_ID,
                UserId = user.Id
            });
             
            modelBuilder.Entity<AddressEntity>().HasData(
    new AddressEntity { Id = 55, City = "City1", Street = "Street1", PostalCode = "00001" },
    new AddressEntity { Id = 66, City = "City2", Street = "Street2", PostalCode = "00002" }
);

            modelBuilder.Entity<EmployerEntity>().HasData(
                new EmployerEntity { EmployerId = 55, FirstName = "John", LastName = "Doe", CompanyName = "JDoe Inc.", NIP = "1234567890", AddressId = 55 },
                new EmployerEntity { EmployerId = 66, FirstName = "Jane", LastName = "Doe", CompanyName = "JDoe & Co.", NIP = "0987654321", AddressId = 66 }
            );

            modelBuilder.Entity<EmployeeEntity>().HasData(
                new EmployeeEntity { Id = 55, FirstName = "Alice", LastName = "Smith", PESEL = "85050512345", Position = "Manager", Department = "HR", EmployerId = 55 },
                new EmployeeEntity { Id = 66, FirstName = "Bob", LastName = "Johnson", PESEL = "90090512345", Position = "Developer", Department = "IT", EmployerId = 66 }
            );


            modelBuilder.Entity<EmployerEntity>()
    .HasOne(e => e.Address)
    .WithMany()
    .HasForeignKey(e => e.AddressId).IsRequired()
    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EmployeeEntity>()
    .HasOne(e => e.Employer)
    .WithMany(p => p.Employees)
    .HasForeignKey(e => e.EmployerId);
        }
    }
}
