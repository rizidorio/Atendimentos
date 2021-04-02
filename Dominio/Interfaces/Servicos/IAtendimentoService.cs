using Dominio.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Servicos
{
    public interface IAtendimentoService : IDisposable
    {
        Task<AtendimentoDto> Salvar(AtendimentoDto atendimentoDto);
        Task Remover(int id);
        Task<AtendimentoDto> PegarPorId(int id);
        Task<IEnumerable<AtendimentoDto>> ListarTodos();
        Task<IEnumerable<AtendimentoDto>> ListarPorData(DateTime data);
        Task<IEnumerable<AtendimentoDto>> ListarPorServico(int servicoId);
        Task<IEnumerable<AtendimentoDto>> ListarPorFuncionario(int funcionarioId);
        Task<IEnumerable<AtendimentoDto>> ListarPorFormaPagamento(int formaPagamentoId);
        Task<IEnumerable<AtendimentoDto>> ListarPorCliente(int clienteId);
    }
}
