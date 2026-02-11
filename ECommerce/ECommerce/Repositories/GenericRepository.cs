using ECommerce.Context;
using ECommerce.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerce.Repositories
{
    public class GenericRepository<TEntity>(AppDbContext _dbContext) where TEntity : class
    {
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
                return await _dbContext.Set<TEntity>().ToListAsync();
        }

        /*Fk Product-Cat Inner Prod-Cat*/
        public async Task<IEnumerable<TEntity>> GetAllAsync(
            Expression<Func<TEntity, bool>>[]? conditions = null, //Condicionales Where
            Expression<Func<TEntity, object>>[]? includes = null
            )
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();
                       
            if(conditions is not null)
              foreach(var condition in conditions) query = query.Where(condition);

            if(includes is not null)
             foreach (var include in includes) query = query.Include(include);


            return await query.ToListAsync();

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
