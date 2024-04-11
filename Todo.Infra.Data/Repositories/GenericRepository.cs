using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Interfaces;
using Todo.Infra.Data.Context;

namespace Todo.Infra.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public readonly ToDoDbContext _toDoDbContext;
        private readonly DbSet<TEntity> _entities;

        public GenericRepository(ToDoDbContext toDoDbContext)
        {
            _toDoDbContext = toDoDbContext;
            _entities = toDoDbContext.Set<TEntity>();
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            _entities.Add(entity);
            await _toDoDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(TEntity entity)
        {
            _entities.Remove(entity);
            await _toDoDbContext.SaveChangesAsync();
            return entity;
        }

        public void Dispose()
        {
            _toDoDbContext.Dispose();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public void Save()
        {
            _toDoDbContext.SaveChanges();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _entities.Update(entity);
            await _toDoDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
