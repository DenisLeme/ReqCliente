namespace TesteCliente.Models
{
    public class Clientes
    {
        public decimal ClienteId { get; set; }
        public string? Cliente { get; set; }
        public string TipoCliente { get; set; }
        public string NomeContato { get; set; }
        public decimal TelefoneContato { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public decimal Logradouro { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }


    }
}
