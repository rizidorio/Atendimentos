using Dominio.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Servicos
{
    public interface IFuncionarioService : IDisposable
    {
        Task<FuncionarioDto> Salvar(FuncionarioDto funcionarioDto);
        Task Remover(int id);
        Task<FuncionarioDto> PegarPorId(int id);
        Task<IEnumerable<FuncionarioDto>> ListarTodos();
        Task<IEnumerable<FuncionarioDto>> ListarPorNascimento(DateTime dataNascimento);
        Task<IEnumerable<FuncionarioDto>> ListarPorFuncao(string funcao);
        Task<IEnumerable<FuncionarioDto>> ListarPorServico(int servicoId);
    }
}
