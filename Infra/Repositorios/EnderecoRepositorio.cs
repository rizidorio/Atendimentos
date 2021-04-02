using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class EnderecoRepositorio : BaseRepositorio<Endereco>, IEnderecoRepositorio
    {
        public EnderecoRepositorio(Contexto.SqlServerContexto contexto) : base(contexto)
        {
        }

        public async Task<Endereco> PegarPorCep(string cep)
        {
            var enderecos = await ListarTodos();

            return enderecos.FirstOrDefault(e => e.Cep.Equals(cep));
        }
    }
}
