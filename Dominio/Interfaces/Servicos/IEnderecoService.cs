using Dominio.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Servicos
{
    public interface IEnderecoService : IDisposable
    {
        Task<EnderecoDto> Salvar(EnderecoDto enderecoDto);
        Task Remover(int id);
        Task<EnderecoDto> PegarPorId(int id);
        Task<IEnumerable<EnderecoDto>> ListarTodos();
        Task<IEnumerable<EnderecoDto>> ListarPorBairro(string bairro);
        Task<IEnumerable<EnderecoDto>> ListarPorCidade(string Cidade);
    }
}
