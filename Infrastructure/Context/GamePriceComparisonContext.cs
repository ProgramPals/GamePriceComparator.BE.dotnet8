using Microsoft.EntityFrameworkCore;
using Domain;

namespace Infrastructure.Context;
    public class GamePriceComparisonContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<GameImage> GameImages { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<PriceAlert> PriceAlerts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Platform> Platforms { get; set; }

        public GamePriceComparisonContext(DbContextOptions<GamePriceComparisonContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .HasMany(g => g.Genres)
                .WithMany(g => g.Games);

            modelBuilder.Entity<Game>()
                .HasMany(g => g.Platforms)
                .WithMany(p => p.Games);

            modelBuilder.Entity<GameImage>()
                .HasOne(gi => gi.Game)
                .WithMany(g => g.GameImages)
                .HasForeignKey(gi => gi.GameId);

            modelBuilder.Entity<Price>()
                .HasOne(p => p.Game)
                .WithMany(g => g.Prices)
                .HasForeignKey(p => p.GameId);

            modelBuilder.Entity<Price>()
                .HasOne(p => p.Store)
                .WithMany(s => s.Prices)
                .HasForeignKey(p => p.StoreId);

            modelBuilder.Entity<Wishlist>()
                .HasOne(w => w.User)
                .WithMany(u => u.Wishlists)
                .HasForeignKey(w => w.UserId);

            modelBuilder.Entity<Wishlist>()
                .HasOne(w => w.Game)
                .WithMany(g => g.Wishlists)
                .HasForeignKey(w => w.GameId);

            modelBuilder.Entity<PriceAlert>()
                .HasOne(pa => pa.User)
                .WithMany(u => u.PriceAlerts)
                .HasForeignKey(pa => pa.UserId);

            modelBuilder.Entity<PriceAlert>()
                .HasOne(pa => pa.Game)
                .WithMany(g => g.PriceAlerts)
                .HasForeignKey(pa => pa.GameId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Game)
                .WithMany(g => g.Reviews)
                .HasForeignKey(r => r.GameId);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.User)
                .WithMany(u => u.Transactions)
                .HasForeignKey(t => t.UserId);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Game)
                .WithMany(g => g.Transactions)
                .HasForeignKey(t => t.GameId);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Store)
                .WithMany(s => s.Transactions)
                .HasForeignKey(t => t.StoreId);
        }
    }
