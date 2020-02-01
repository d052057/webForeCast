using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebForecast.Models
{
    public partial class forecastContext : DbContext
    {
        public forecastContext()
        {
        }

        public forecastContext(DbContextOptions<forecastContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WeatherForecast> WeatherForecast { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress;Database=forecast;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>(entity =>
            {
                entity.HasKey(e => e.Date)
                    .HasName("PK__Table__77387D0672C690A7");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
