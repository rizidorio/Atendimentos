using Dominio.Entidades;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorios
{
    public interface IFormaPagamentoRepositorio : IBaseRepositorio<FormaPagamento>
    {
        Task<FormaPagamento> PegarPorCodigo(string codigo);
    }
}