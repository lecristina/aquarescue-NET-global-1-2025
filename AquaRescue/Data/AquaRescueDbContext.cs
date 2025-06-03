using Microsoft.EntityFrameworkCore;
using AquaRescue.Models;

namespace AquaRescue.Data
{
    public class AquaRescueDbContext : DbContext
    {
        public AquaRescueDbContext(DbContextOptions<AquaRescueDbContext> options)
            : base(options)
        {
        }

        // Adicione TODOS os DbSet aqui:
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Comunidade> Comunidades { get; set; }
        public DbSet<Previsao> Previsoes { get; set; }
        public DbSet<LogCalculo> LogsCalculo { get; set; }
        public DbSet<DadosMeteorologicos> DadosMeteorologicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("T_AQUA_USUARIO");
            modelBuilder.Entity<Comunidade>().ToTable("T_AQUA_COMUNIDADE");
            modelBuilder.Entity<Previsao>().ToTable("T_AQUA_PREVISAO");
            modelBuilder.Entity<LogCalculo>().ToTable("T_AQUA_LOG_CALCULO");
            modelBuilder.Entity<DadosMeteorologicos>().ToTable("T_AQUA_DADOS_METEOROLOGICOS");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseOracle("User Id=rm555241;Password=230205;Data Source=oracle.fiap.com.br:1521/orcl")
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }
    }
}
