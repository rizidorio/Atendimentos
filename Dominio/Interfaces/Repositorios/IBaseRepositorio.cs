using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorios
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        Task<TEntity> Adicionar(TEntity entity);
        Task<TEntity> Atualizar(TEntity entity);
        Task<TEntity> Remover(TEntity entity);
        Task<TEntity> BuscarPorId(int id);
        Task<IEnumerable<TEntity>> ListarTodos();
    }
}