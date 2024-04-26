using AvgUniversitary.Core.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Universitary.Infrastructure.Persistence.Context;

namespace Universitary.Infrastructure.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        private readonly UniversitaryAvgContext _ctx;
        public BaseRepository(UniversitaryAvgContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Delete(int id)
        {
            T entity = await GetById(id);
            _ctx.Set<T>().Remove(entity);
        }

        public async Task<List<T>> GetAll()
        {
            return await _ctx.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetAllWithInclude(List<string> includes)
        {
            var query = _ctx.Set<T>().AsQueryable();
            foreach(var include in includes) 
            {
                query.Include(include);
            }
            return await query.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _ctx.Set<T>().FindAsync(id);
        }

        public async Task<T> Save(T entity)
        {
            await _ctx.Set<T>().AddAsync(entity);
            await _ctx.SaveChangesAsync();
            return entity;

        }

        public async Task Update(T entity, int id)
        {
            T entry = await _ctx.Set<T>().FindAsync(id);
            _ctx.Entry(entry).CurrentValues.SetValues(entity);
            await _ctx.SaveChangesAsync();
        }
    }
}
