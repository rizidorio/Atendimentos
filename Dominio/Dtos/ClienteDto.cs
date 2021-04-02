using System;

namespace Dominio.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public int Sexo { get; set; }
        public int EstadoCivil { get; set; }
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public int TipoTelefone1 { get; set; }
        public string Telefone2 { get; set; }
        public int TipoTelefone2 { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime Alteracao { get; set; }
        public DateTime UltimoAtendimento { get; set; }
        public int EnderecoId { get; set; }
    }
}
