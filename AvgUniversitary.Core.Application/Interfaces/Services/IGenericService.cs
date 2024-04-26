
namespace AvgUniversitary.Core.Application.Interfaces.Services
{
    public interface IGenericService<DtoAdd,DtoUpdate,DtoGet>
       where DtoAdd : class
       where DtoUpdate:class
       where DtoGet :class
    {
        Task<List<DtoGet>> GetAllAsync();
        Task<DtoGet> GetByIdAsync(int id);
        Task UpdateAsync(DtoUpdate dtoUpdate, int id);
        Task DeleteAsync(int id);
        Task<DtoAdd> AddAsync(DtoAdd dtoAdd); 
    }
}
