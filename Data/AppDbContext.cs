using CodeFirstGames.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstGames.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Representa a tabela de desenvolvedoras
        public DbSet<Desenvolvedora> Desenvolvedoras => Set<Desenvolvedora>();

        // Representa a tabela de jogos
        public DbSet<Game> Games => Set<Game>();

        // Representa a tabela de generos
        public DbSet<Genero> Generos => Set<Genero>();

    }
}
