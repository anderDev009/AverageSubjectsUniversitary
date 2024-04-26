

using AutoMapper;
using AvgUniversitary.Core.Application.Dtos.UniversityDtos;
using AvgUniversitary.Core.Application.Interfaces.Repositories;
using AvgUniversitary.Core.Application.Interfaces.Services;
using AvgUniversitary.Core.Domain.Entities;

namespace AvgUniversitary.Core.Application.Services
{
    public class UniversityService : GenericService<UniversityDtoAdd, UniversityDtoUpdate, UniversityDtoGet,University>, IUniversityService
    {
        private readonly IUniversityRepository _universityRepository;
        private readonly IMapper _mapper;
        public UniversityService(IUniversityRepository repository, IMapper mapper) : base(repository, mapper) 
        {
            _universityRepository = repository;
            _mapper = mapper;
        }
    }
}
