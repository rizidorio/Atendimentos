using Dominio.Entidades;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorios
{
    public interface IEnderecoRepositorio : IBaseRepositorio<Endereco>
    {
        Task<Endereco> PegarPorCep(string cep);
    }
}