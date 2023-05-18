using BookSalesCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesData
{
    public class DatabaseContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // OnConfiguring metodu EntityFrameworkCore ile gelir ve veritabanı bağlantı ayarlarını yapmamızı sağlar.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=BookSales; Trusted_Connection=True");
            //optionsBuilder.UseSqlServer(@"Server=CanlıServerAdı; Database=CanlıdakiDatabase; Username=CanlıVeritabanıKullanıcıAdı; Password=CanlıVeritabanıŞifre");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().Property(a => a.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<AppUser>().Property(a => a.Surname).HasMaxLength(50);
            modelBuilder.Entity<AppUser>().Property(a => a.UserName).HasColumnType("varchar(50)").HasMaxLength(50);
            modelBuilder.Entity<AppUser>().Property(a => a.Password).IsRequired().HasColumnType("nvarchar(100)").HasMaxLength(100);
            modelBuilder.Entity<AppUser>().Property(a => a.Email).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<AppUser>().Property(a => a.Phone).HasMaxLength(20);

            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = 1,
                Email = "info@BookSales.com",
                Password="123",
                UserName ="Admin",
                IsActive = true,
                IsAdmin = true,
                Name = "Admin",
                UserGuid = Guid.NewGuid(), // kullanıcıya benzersiz bir id ne oluştururmuş
            });

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // uygulamadaki tüm Configurations classlarını burada çalıştırır.

            base.OnModelCreating(modelBuilder);
        }
    }
}
