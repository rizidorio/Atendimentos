using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class FormaPagamentoRepositorio : BaseRepositorio<FormaPagamento>, IFormaPagamentoRepositorio
    {
        public FormaPagamentoRepositorio(Contexto.SqlServerContexto contexto) : base(contexto)
        {
        }

        public async Task<FormaPagamento> PegarPorCodigo(string codigo)
        {
            var formasPagamento = await ListarTodos();

            var formaPagamento = formasPagamento.FirstOrDefault(fp => fp.Codigo.Equals(codigo, StringComparison.CurrentCultureIgnoreCase));

            return formaPagamento;
        }
    }
}
