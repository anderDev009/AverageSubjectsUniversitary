
using AvgUniversitary.Core.Domain.Common;

namespace AvgUniversitary.Core.Domain.Entities
{
    public class Subject : BaseEntity
    {
        public int Credits {  get; set; }

        public int IdUniversity { get; set; }
        public University? University { get; set; }
    }

}
