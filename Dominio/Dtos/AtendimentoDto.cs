using System;

namespace Dominio.Dtos
{
    public class AtendimentoDto
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
        public int ServicoId { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorComDesconto { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Troco { get; set; }
        public int FormaPagamentoId { get; set; }
    }
}
