using Dominio.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Servicos
{
    public interface IClienteService : IDisposable
    {
        Task<ClienteDto> Salvar(ClienteDto clienteDto);
        Task Remover(int id);
        Task<ClienteDto> PegarPorId(int id);
        Task<IEnumerable<ClienteDto>> ListarTodos();
        Task<IEnumerable<ClienteDto>> ListarPorNascimento(DateTime dataNascimento);
    }
}
