
using AutoMapper;
using University.Blazor.Domain.Models.HtmlModels;
using University.Blazor.Domain.Models.RequestModel;

namespace University.Blazor.Application.Mappings.SectionMapping;

public class SectionMappingProfile : Profile
{
    public SectionMappingProfile()
    {
        CreateMap<SectionModel, UpdateSectionRequestModel>()
            .ReverseMap();

    }

}