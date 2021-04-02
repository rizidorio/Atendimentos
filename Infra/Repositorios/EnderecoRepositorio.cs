using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;

namespace Infra.Repositorios
{
    public class EnderecoRepositorio : BaseRepositorio<Endereco>, IEnderecoRepositorio
    {
        public EnderecoRepositorio(Contexto.SqlServerContexto contexto) : base(contexto)
        {
        }
    }
}
