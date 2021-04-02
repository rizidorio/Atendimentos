using Dominio.Interfaces.Repositorios;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        private readonly SqlServerContexto _contexto;
        private readonly DbSet<TEntity> entities;

        public BaseRepositorio(SqlServerContexto contexto)
        {
            _contexto = contexto;
            entities = contexto.Set<TEntity>();
        }

        public async Task<TEntity> Adicionar(TEntity entity)
        {
            await entities.AddAsync(entity);
            _contexto.SaveChanges();

            return entity;
        }

        public async Task<TEntity> Atualizar(TEntity entity)
        {
            entities.Update(entity);
            await _contexto.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> BuscarPorId(int id)
        {
            return await entities.FindAsync(id);
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public async Task<IEnumerable<TEntity>> ListarTodos()
        {
            return await entities.ToListAsync();
        }

        public async Task<TEntity> Remover(TEntity entity)
        {
            entities.Remove(entity);
            await _contexto.SaveChangesAsync();
            return entity;
        }
    }
}
