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
        Task<FormaPagamentoDto> PegarPorCodigo(string codigo);
        Task<IEnumerable<FormaPagamentoDto>> ListarTodos();
        Task<bool> JaExiste(string nome, string codigo);
    }
}
