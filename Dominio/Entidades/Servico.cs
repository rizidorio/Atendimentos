using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Servico
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Alteracao { get; set; }
        public bool Ativo { get; set; }
        public bool Apagado { get; set; }

        public virtual IEnumerable<Funcionario> Funcionarios { get; set; }

        private Servico()
        { }

        public Servico(int id, string codigo, string nome, string descricao, decimal valor, DateTime alteracao, bool ativo = true, bool apagado = false)
        {
            Id = id;
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Alteracao = alteracao;
            Ativo = ativo;
            Apagado = apagado;
        }
    }
}