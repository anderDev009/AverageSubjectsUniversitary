
using AvgUniversitary.Core.Application.Dtos.UniversityDtos;
using AvgUniversitary.Core.Domain.Entities;

namespace AvgUniversitary.Core.Application.Interfaces.Services
{
    public interface IUniversityService : IGenericService<UniversityDtoAdd,UniversityDtoUpdate,UniversityDtoGet>
    {
    }
}
