using AutoMapper;
using University.Application.Features.Commands.CreateLink;
using University.Application.Features.Commands.UpdateLink;
using University.Application.Features.Queries.ViewModels;
using University.Domain.Models;

namespace University.Application.Mappings.LinkMapping;

public class LinkMappingProfile : Profile
{
    public LinkMappingProfile()
    {
        CreateMap<Link, LinkDTO>()
            .ReverseMap();

        CreateMap<Link, UpdateLinkDTO>()
            .ForMember(member => member.Name, member2 => member2.MapFrom(x => x.Name))
            .ForMember(member => member.Href, member2 => member2.MapFrom(x => x.Href))
            .ForMember(member => member.Id, member2 => member2.MapFrom(x => x.Id))
            .ReverseMap();


        CreateMap<Link, LinkViewModel>()
            .ReverseMap();

    }
    
}