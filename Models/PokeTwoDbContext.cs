using Microsoft.EntityFrameworkCore;

namespace poketwo_manager.Models
{
    public class PokeTwoDbContext : DbContext
    {
        public DbSet<UserPokemon> UserPokemon { get; set; }

        public PokeTwoDbContext(DbContextOptions<PokeTwoDbContext> options)
            : base(options)
        {
        }
    }
}