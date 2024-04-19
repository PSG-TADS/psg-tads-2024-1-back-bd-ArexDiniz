using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace codigo.Models
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
    }
 

