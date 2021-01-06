using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

#nullable disable

namespace HousePriceAPI.Data
{
    public partial class Sims3Context : DbContext
    {
        public Sims3Context()
        {
        }

        public Sims3Context(DbContextOptions<Sims3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Bucharest> Bucharests { get; set; }
        public virtual DbSet<Statistica> Statistics { get; set; }
        public virtual DbSet<Texa> Texas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bucharest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bucharest");
            });

            modelBuilder.Entity<Statistica>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Statistica");

                entity.Property(e => e.DateOfStatistic)
                    .HasColumnType("date")
                    .HasColumnName("date_of_statistic");

                entity.Property(e => e.MaxPret).HasColumnName("max_pret");

                entity.Property(e => e.MediaPret).HasColumnName("media_pret");

                entity.Property(e => e.MediaRating).HasColumnName("media_rating");

                entity.Property(e => e.MediaSuprafata).HasColumnName("media_suprafata");

                entity.Property(e => e.MinPret).HasColumnName("min_pret");

                entity.Property(e => e.NumeOras)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nume_oras");
            });

            modelBuilder.Entity<Texa>(entity =>
            {
                entity.HasKey(e => e.PredictionId)
                    .HasName("PK__Texas__F1AE77BF2DC6110A");

                entity.Property(e => e.PredictionId).HasColumnName("prediction_id");

                entity.Property(e => e.Bathrooms).HasColumnName("bathrooms");

                entity.Property(e => e.Bedrooms).HasColumnName("bedrooms");

                entity.Property(e => e.Condition).HasColumnName("condition");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("date");

                entity.Property(e => e.Floors).HasColumnName("floors");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lat).HasColumnName("lat");

                entity.Property(e => e.Long).HasColumnName("long");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.SqftAbove).HasColumnName("sqft_above");

                entity.Property(e => e.SqftBasement).HasColumnName("sqft_basement");

                entity.Property(e => e.SqftLiving).HasColumnName("sqft_living");

                entity.Property(e => e.SqftLiving15).HasColumnName("sqft_living15");

                entity.Property(e => e.SqftLot).HasColumnName("sqft_lot");

                entity.Property(e => e.SqftLot15).HasColumnName("sqft_lot15");

                entity.Property(e => e.View).HasColumnName("view");

                entity.Property(e => e.Waterfront).HasColumnName("waterfront");

                entity.Property(e => e.YrBuilt).HasColumnName("yr_built");

                entity.Property(e => e.YrRenovated).HasColumnName("yr_renovated");

                entity.Property(e => e.Zipcode).HasColumnName("zipcode");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
