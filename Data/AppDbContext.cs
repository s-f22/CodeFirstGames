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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API
            // Configura os relacionamentos entre as entidades
            // Configura o relacionamento 1:N entre desenvolvedora e jogos
            modelBuilder.Entity<Desenvolvedora>()
                .HasMany(d => d.Games)
                .WithOne(g => g.Desenvolvedora)
                .HasForeignKey(g => g.DesenvolvedoraId);

            modelBuilder.Entity<Game>()
                .HasMany(g => g.Generos)
                .WithMany(g => g.Games);
        }


    }
}
