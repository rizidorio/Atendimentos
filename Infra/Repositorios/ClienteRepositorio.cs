using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;

namespace Infra.Repositorios
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(Contexto.SqlServerContexto contexto) : base(contexto)
        {
        }
    }
}
