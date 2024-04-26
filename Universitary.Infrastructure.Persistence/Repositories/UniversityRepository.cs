
using AvgUniversitary.Core.Application.Interfaces.Repositories;
using AvgUniversitary.Core.Domain.Entities;
using Universitary.Infrastructure.Persistence.Context;

namespace Universitary.Infrastructure.Persistence.Repositories
{
    public class UniversityRepository : BaseRepository<University>, IUniversityRepository
    {
        private readonly UniversitaryAvgContext _ctx;
        public UniversityRepository(UniversitaryAvgContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
