using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollector2.Models;

namespace TrashCollector2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Id = "0470c734-f330-4c24-b6f7-a6731c70a539",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "37b11827-dc6f-4e29-b663-9ae91d5ae31b"
                }
                );
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Id = "0479c734-f330-4c24-b6f7-a6731c70a539",
                Name = "Customer",
                NormalizedName = "CUSTOMER",
                ConcurrencyStamp = "37b11827-dc6f-4e29-b663-9ae91d5ae31c"
            }
            );
            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Id = "0477c734-f330-4c24-b6f7-a6731c70a539",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                    ConcurrencyStamp = "37b11827-dc6f-4e29-b663-9ae91d5ae31e"
                }
                );
                
        }
        public DbSet<TrashCollector2.Models.Customer> Customer { get; set; }
        public DbSet<TrashCollector2.Models.Employee> Employee { get; set; }
    }
}
