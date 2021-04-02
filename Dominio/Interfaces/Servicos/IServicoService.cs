using Dominio.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Servicos
{
    public interface IServicoService : IDisposable
    {
        Task<ServicoDto> Salvar(ServicoDto servicoDto);
        Task Remover(int id);
        Task<ServicoDto> PegarPorId(int id);
        Task<IEnumerable<ServicoDto>> ListarTodos();
        Task<IEnumerable<ServicoDto>> ListarSomenteAtivo();
    }
}
