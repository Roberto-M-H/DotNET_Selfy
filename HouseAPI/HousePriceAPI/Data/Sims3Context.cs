using Microsoft.EntityFrameworkCore;

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
        public virtual DbSet<Melbourne> Melbournes { get; set; }
        public virtual DbSet<Statistics> Statistics { get; set; }
        public virtual DbSet<Texa> Texas { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=sims3.database.windows.net;Database=Sims3;User Id=Sims3;Password=Echipa.net;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bucharest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bucharest");
            });

            modelBuilder.Entity<Melbourne>(entity =>
            {
                entity.HasKey(e => e.PredictionId);

                entity.ToTable("Melbourne");

                entity.Property(e => e.PredictionId)
                    .HasMaxLength(50)
                    .HasColumnName("prediction_id");

                entity.Property(e => e.Bedroom2).HasMaxLength(50);

                entity.Property(e => e.CouncilArea)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Regionname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Statistics>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.DateOfStatistic)
                    .HasColumnType("date")
                    .HasColumnName("date_of_statistic");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.MaxPrice).HasColumnName("max_price");

                entity.Property(e => e.MinPrice).HasColumnName("min_price");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.SqftLot).HasColumnName("sqftlot");
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

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("created_date");

                entity.Property(e => e.DarkTheme).HasColumnName("dark_theme");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email_address");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Verified).HasColumnName("verified");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
