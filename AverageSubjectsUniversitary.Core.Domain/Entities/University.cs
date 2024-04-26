

using AvgUniversitary.Core.Domain.Common;

namespace AvgUniversitary.Core.Domain.Entities
{
    public class University : BaseEntity
    {
        public decimal PriceCredits { get; set; }
        public List<Subject>? Subjects {  get; set; }
    }
}
