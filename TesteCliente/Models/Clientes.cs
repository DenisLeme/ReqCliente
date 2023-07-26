using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteCliente.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string? Cliente { get; set; }
        public string TipoCliente { get; set; }
        public string NomeContato { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TelefoneContato { get; set; }

        public string Cidade { get; set; }
        public string Bairro { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Logradouro { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
