using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Configuration;

namespace CommonModels
{
	public class PokeAnalizeDbContext : DbContext
	{

		public virtual DbSet<Battle> Battles { get; set; }
		public virtual DbSet<Party> Parties { get; set; }
		public virtual DbSet<Pokemon> Pokemons { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
			optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Database=PokeAnalize;Integrated Security=True;Connect Timeout=30");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<Pokemon>(p =>
			//	{
			//		p.HasOne("CommonModel.Battle", "Battles")
			//		.WithMany("EnemysPokemons")
			//		.HasForeignKey("BattleId");

			//		p.HasOne("CommonModel.Party", "Parties")
			//		.WithMany("Pokemons")
			//		.HasForeignKey("PartyId");
			//	});

			//modelBuilder.Entity<Party>(p =>
			// {
			//	 p.HasOne("CommonModel.Pokemon", "Pokemons")
			//	 .WithMany("Parties")
			//	 .HasForeignKey("PokemonId");

			//	 p.HasOne("CommonModel.Battle", "Battle")
			//	 .WithOne("Party");
			// });

			//modelBuilder.Entity<Battle>(b =>
			//{
			//	b.HasOne("CommonModel.Party", "MyParty")
			//	.WithOne("Battle")
			//	.HasForeignKey("MyPartyId");

			//	b.HasOne("CommonModel.Pokemon", "EnemysPokemons")
			//	.WithMany("Battles")
			//	.HasForeignKey("EnemysPokemonId");
			//});
		}
	}
}