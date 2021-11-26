using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OfficeWork.Models;

namespace OfficeWork.Data
{
    public class ApplicationDbContext : IdentityDbContext<Register>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Department> department { get; set; }
        public DbSet<Designation> designation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Register>()
                .Property(e => e.Device_id)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.DateOfBirth)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Contact)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.BloodGroup)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.UserType)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Gender)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Bio)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.First_name)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Middle_name)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Last_name)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.NickName)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Address)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.MaritalStatus)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Designation)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.DesignationDate)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Company_id)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Department)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Branch)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Fb)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Linkedin)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Image)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.City)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.UpdateDate)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.Addeddate)
                .HasMaxLength(250);
            modelBuilder.Entity<Register>()
                .Property(e => e.EntrollDate)
                .HasMaxLength(250);

            

        }


    }
}
