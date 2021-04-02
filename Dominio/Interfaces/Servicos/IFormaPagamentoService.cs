using Dominio.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Servicos
{
    public interface IFormaPagamentoService : IDisposable
    {
        Task<FormaPagamentoDto> Salvar(FormaPagamentoDto formaPagamentoDto);
        Task Remover(string id);
        Task<FormaPagamentoDto> PegarPorId(int id);
        Task<FormaPagamentoDto> PegarPorCodigo(string codgio);
        Task<IEnumerable<FormaPagamentoDto>> ListarTodos();
        Task<IEnumerable<FormaPagamentoDto>> ListarSomenteAtivo();
        Task<bool> JaExiste(string nome, string codigo);
    }
}
