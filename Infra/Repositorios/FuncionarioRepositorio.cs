using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;

namespace Infra.Repositorios
{
    public class FuncionarioRepositorio : BaseRepositorio<Funcionario>, IFuncionarioRepositorio
    {
        public FuncionarioRepositorio(Contexto.SqlServerContexto contexto) : base(contexto)
        {
        }
    }
}
