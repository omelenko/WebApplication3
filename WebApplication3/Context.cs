using Microsoft.EntityFrameworkCore;
namespace WebApplication3
{
	public class Context : DbContext
	{
		public DbSet<New> News => Set<New>();
		public Context()
		{
			//Database.EnsureDeleted();
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data source = database.db");
		}
	}
}
