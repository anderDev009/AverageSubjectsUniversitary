using AutoMapper;
using AvgUniversitary.Core.Application.Dtos.SubjectDtos;
using AvgUniversitary.Core.Application.Dtos.UniversityDtos;
using AvgUniversitary.Core.Domain.Entities;

namespace AvgUniversitary.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region University
            CreateMap<University, UniversityDtoAdd>()
                .ReverseMap()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.Subjects, opt => opt.Ignore());

            CreateMap<University, UniversityDtoUpdate>()
                .ReverseMap()
                .ForMember(x => x.Subjects, opt => opt.Ignore());

            CreateMap<University, UniversityDtoGet>();
            #endregion
            #region Subject 
            CreateMap<Subject, SubjectDtoAdd>()
                .ReverseMap()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.University, opt => opt.Ignore());

            CreateMap<Subject, SubjectDtoUpdate>()
                .ReverseMap()
                .ForMember(x => x.University, opt => opt.Ignore());

            CreateMap<Subject, SubjectDtoGet>();
            #endregion
        }
    }
}
