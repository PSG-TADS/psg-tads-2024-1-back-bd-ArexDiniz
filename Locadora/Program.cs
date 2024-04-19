using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locadora
{
    internal class Program
    {
        public class Veiculo
        {
            [Key]
            public int VeiculoID { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Ano { get; set; }
            public float ValorDiaria { get; set; }

            public Boolean Reservado { get; set; }
        }

        public class Cliente
        {
            [Key]
            public int ClienteID { get; set; }
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string Telefone { get; set; }
        }

        public class Reserva
        {
            [Key]
            public int ReservaID { get; set; }
            public int VeiculoID { get; set; }
            [ForeignKey("VeiculoID")]
            public int ClienteID { get; set; }
            [ForeignKey("ClienteID")]
            public DateTime DataInicio { get; set; }
            public DateTime DataFim { get; set; }


            public Veiculo Veiculo { get; set; }

            public virtual Cliente? Cliente { get; set; }
        }
        public class LocadoraContext : DbContext
        {
            public DbSet<Veiculo> Veiculos { get; set; }
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Reserva> Reservas { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                _ = optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS ; Database=Locadora;Trusted_Connection=True;TrustServerCertificate=true");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
