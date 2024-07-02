using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PetFinder.Domain.Entities;

namespace PetFinder.Infrastructure.Database.Context
{
	public class PetFinderDbContext : DbContext
	{
		public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			var connectionString = Environment.GetEnvironmentVariable("DefaultConnection");
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=db_pet_finder;User Id=usr_pet_finder;Password=mysecretpassword;");
        }
    }

	public class PetFinderDbContextFactory : IDesignTimeDbContextFactory<PetFinderDbContext>
	{
		public PetFinderDbContext CreateDbContext(string[] args)
		{
			var builder = new DbContextOptionsBuilder<PetFinderDbContext>();
			var connectionString = Environment.GetEnvironmentVariable("DefaultConnection");
			builder.UseNpgsql(connectionString);

			return new PetFinderDbContext();
		}
	}
}
