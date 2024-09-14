using Microsoft.EntityFrameworkCore;
using Schoolbus.Models;

namespace Schoolbus.Data
{
    internal class SchoolbusContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-RFGQSC7;Initial Catalog=Schoolbus;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bus>().HasKey(b => b.Id);

            modelBuilder.Entity<Bus>().HasOne(b => b.Driver).WithOne(d => d.Bus)
                                      .HasForeignKey<Bus>(b => b.DriverId);

            modelBuilder.Entity<Driver>().HasKey(d => d.Id);

            modelBuilder.Entity<Driver>().HasMany(d => d.Rides).WithOne(r => r.Driver)
                                         .HasForeignKey(r => r.DriverId);
                
            modelBuilder.Entity<Driver>().HasOne(d => d.Bus).WithOne(b => b.Driver)
                                         .HasForeignKey<Bus>(b => b.DriverId);

            modelBuilder.Entity<Parent>().HasKey(p => p.Id);

            modelBuilder.Entity<Parent>().HasMany(p => p.Students).WithOne(s => s.Parent)
                                         .HasForeignKey(s => s.ParentId);

            modelBuilder.Entity<Student>().HasKey(s => s.Id);

            modelBuilder.Entity<Class>().HasKey(c => c.Id);
            modelBuilder.Entity<Class>().HasMany(c => c.Students).WithOne(s => s.Class)
                                        .HasForeignKey(s => s.ClassId);

            modelBuilder.Entity<Holiday>().HasKey(h => h.Id);
         
        }
    }
}
