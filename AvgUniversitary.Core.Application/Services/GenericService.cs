using AutoMapper;
using AvgUniversitary.Core.Application.Interfaces.Repositories;
using AvgUniversitary.Core.Application.Interfaces.Services;


namespace AvgUniversitary.Core.Application.Services
{
    public class GenericService<DtoAdd, DtoUpdate, DtoGet,T> : IGenericService<DtoAdd, DtoUpdate, DtoGet>
       where DtoAdd : class
       where DtoUpdate : class
       where DtoGet : class
    {
        private readonly IBaseRepository<T> _repository;
        private readonly IMapper _mapper;
        public GenericService(IBaseRepository<T> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<DtoAdd> AddAsync(DtoAdd dtoAdd)
        {
            T entity = _mapper.Map<T>(dtoAdd);
            entity = await _repository.Save(entity);
            return _mapper.Map<DtoAdd>(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.Delete(id);
        }

        public async Task<List<DtoGet>> GetAllAsync()
        {

            List<DtoGet> entities = _mapper.Map<List<DtoGet>>(await _repository.GetAll());
            return entities;
        }

        public async Task<DtoGet> GetByIdAsync(int id)
        {
            DtoGet entity = _mapper.Map<DtoGet>(await _repository.GetById(id));
            return entity;
        }

        public async Task UpdateAsync(DtoUpdate dtoUpdate, int id)
        {
            T entity = _mapper.Map<T>(dtoUpdate);
            await _repository.Update(entity, id);
        }
    }
}
