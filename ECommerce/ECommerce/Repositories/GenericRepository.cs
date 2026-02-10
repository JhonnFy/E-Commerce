using Microsoft.EntityFrameworkCore;
using ECommerce.Context;

namespace ECommerce.Repositories
{
    public class GenericRepository<TEntity>(AppDbContext _dbContext) where TEntity : class
    {
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
                return await _dbContext.Set<TEntity>().ToListAsync();
        }


        //Metodo Para Agregar
        public async Task AddAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        //Metodo Para Retornar por Id
        public async Task<TEntity?>GetByIdAsync(int entityId)
        {
            return await _dbContext.Set<TEntity>().FindAsync(entityId);
        }

        //Metodo Para Editar
        public async Task EditAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        //Metodo Para Eliminar
        public async Task DeleteAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }


    }
}
