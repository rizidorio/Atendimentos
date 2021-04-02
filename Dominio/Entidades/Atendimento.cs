using System;

namespace Dominio.Entidades
{
    public class Atendimento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public int ServicoId { get; set; }
        public virtual Servico Servico { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorComDesconto { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Troco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        private Atendimento()
        { }

        public Atendimento(int id, DateTime data, TimeSpan hora, int clienteId, int funcionarioId, int servicoId, decimal valorTotal, decimal desconto, decimal valorComDesconto, decimal valorPago, decimal troco, int formaPagamentoId)
        {
            Id = id;
            Data = data;
            Hora = hora;
            ClienteId = clienteId;
            FuncionarioId = funcionarioId;
            ServicoId = servicoId;
            ValorTotal = valorTotal;
            Desconto = desconto;
            ValorComDesconto = valorComDesconto;
            ValorPago = valorPago;
            Troco = troco;
            FormaPagamentoId = formaPagamentoId;
        }
    }
}
