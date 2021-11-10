using System.IO;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Docker.Lecture.Live.Data {
    public class AppDbContext : DbContext {

        public DbSet<Movie> Movies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            if (!options.IsConfigured) {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("SqlServerConnection");
                options.UseSqlServer(connectionString);
            }
        }

        public class Movie {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Year { get; set; }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            var ids = 1;
            var stock = new Faker<Movie>()
                .RuleFor(m => m.Id, f => ids++)
                .RuleFor(m => m.Name, f => f.Commerce.ProductName())
                .RuleFor(m => m.Year, f => f.Random.Int(1500, 2021));

            // generate 100 items
            modelBuilder
                .Entity<Movie>()
                .HasData(stock.Generate(100));
        }
    }
}