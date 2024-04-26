namespace AvgUniversitary.Core.Application.Interfaces.Repositories
{
    public interface IBaseRepository<T>
    {
        Task Update(T entity, int id);
        Task Delete(int id);
        Task<T> Save(T entity);
        Task<List<T>> GetAll();
        Task<List<T>> GetAllWithInclude(List<string> includes);
        Task<T> GetById(int id);
    }
}
