
using AvgUniversitary.Core.Application.Interfaces.Repositories;
using AvgUniversitary.Core.Domain.Entities;
using Universitary.Infrastructure.Persistence.Context;

namespace Universitary.Infrastructure.Persistence.Repositories
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        private readonly UniversitaryAvgContext _ctx;
        public SubjectRepository(UniversitaryAvgContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
