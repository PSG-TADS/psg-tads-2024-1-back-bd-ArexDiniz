
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace codigo
{
    public class Program
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
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
