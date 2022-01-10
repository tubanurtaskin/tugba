using AutoMapper;
using University.Application.Features.Commands.CreateSection;
using University.Application.Features.Commands.UpdateLink;
using University.Application.Features.Queries.ViewModels;
using University.Domain.Models;

namespace University.Application.Mappings.LinkMapping;

public class SectionMappingProfile : Profile
{
    public SectionMappingProfile()
    {
        CreateMap<Section, SectionDTO>()
            .ReverseMap();

        CreateMap<Section, UpdateSectionDTO>()
            .ForMember(member => member.Content, member2 => member2.MapFrom(x => x.Content))
            .ForMember(member => member.Priority, member2 => member2.MapFrom(x => x.Priority))
            .ForMember(member => member.Id, member2 => member2.MapFrom(x => x.Id))
            .ReverseMap();


        CreateMap<Section, SectionViewModel>()
            .ReverseMap();

    }
    
}