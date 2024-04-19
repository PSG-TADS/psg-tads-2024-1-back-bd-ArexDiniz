using Microsoft.EntityFrameworkCore;

namespace codigo.Models
{
        public class LocacaoContext : DbContext
        {
            public DbSet<Veiculo> Veiculos { get; set; } = null!;
            public DbSet<Cliente> Cliente { get; set; } = null!;
            public DbSet<Reserva> Reservas { get; set; } = null!;

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                _ = optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS ; Database=LocadoraDeVeiculos;Trusted_Connection=True;TrustServerCertificate=true");
            }
        }
    }

