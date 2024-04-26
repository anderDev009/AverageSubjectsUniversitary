
using AvgUniversitary.Core.Application.Dtos.UniversityDtos;

namespace AvgUniversitary.Core.Application.Dtos.SubjectDtos
{
    public class SubjectDtoGet 
    {
        public int Id { get; set; }
        public int Credits {  get; set; }
        public string Name { get; set; }
        public UniversityDtoGet? University { get; set; }
    }
}
