using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;

namespace Infra.Repositorios
{
    public class AtendimentoRepositorio : BaseRepositorio<Atendimento>, IAtendimentoRepositorio
    {
        public AtendimentoRepositorio(Contexto.SqlServerContexto contexto) : base(contexto)
        {
        }
    }
}
