
using AutoMapper;
using AvgUniversitary.Core.Application.Dtos.SubjectDtos;
using AvgUniversitary.Core.Application.Interfaces.Repositories;
using AvgUniversitary.Core.Application.Interfaces.Services;
using AvgUniversitary.Core.Domain.Entities;

namespace AvgUniversitary.Core.Application.Services
{
    public class SubjectService : GenericService<SubjectDtoAdd, SubjectDtoUpdate, SubjectDtoGet,Subject>, ISubjectService
    {
        private readonly ISubjectRepository _SubjectRepository;
        private readonly IMapper _mapper;
        public SubjectService(ISubjectRepository repository, IMapper mapper) : base(repository,mapper)
        {
            _SubjectRepository = repository;
            _mapper = mapper;
        }
    }
}
