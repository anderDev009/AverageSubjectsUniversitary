
using AvgUniversitary.Core.Domain.Entities;

namespace AvgUniversitary.Core.Application.Dtos.UniversityDtos
{
    public class UniversityDtoGet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PriceCredits { get; set; }

        public List<Subject>? Subjects {  get; set; }
    }
}
