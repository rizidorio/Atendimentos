using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;

namespace Infra.Repositorios
{
    public class ServicoRepositorio : BaseRepositorio<Servico>, IServicoRepositorio
    {
        public ServicoRepositorio(Contexto.SqlServerContexto contexto) : base(contexto)
        {
        }
    }
}
