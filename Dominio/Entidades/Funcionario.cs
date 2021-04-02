using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Funcionario
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
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public string Funcao { get; set; }
        public bool Ativo { get; set; }
        public bool Apagado { get; set; }

        public virtual IEnumerable<Servico> Servicos { get; set; }

        private Funcionario()
        { }

        public Funcionario(int id, string codigo, string nome, string cpf, string rg, int sexo, int estadoCivil, string email, string telefone1, int tipoTelefone1, string telefone2, int tipoTelefone2, DateTime nascimento, DateTime cadastro, DateTime alteracao, int enderecoId, string funcao, bool ativo = true, bool apagado = false)
        {
            Id = id;
            Codigo = codigo;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            Email = email;
            Telefone1 = telefone1;
            TipoTelefone1 = tipoTelefone1;
            Telefone2 = telefone2;
            TipoTelefone2 = tipoTelefone2;
            Nascimento = nascimento;
            Cadastro = cadastro;
            Alteracao = alteracao;
            EnderecoId = enderecoId;
            Funcao = funcao;
            Ativo = ativo;
            Apagado = apagado;
        }
    }
}