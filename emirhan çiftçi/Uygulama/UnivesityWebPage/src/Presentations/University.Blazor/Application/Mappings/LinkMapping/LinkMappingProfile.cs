
using AutoMapper;
using University.Blazor.Domain.Models.HtmlModels;
using University.Blazor.Domain.Models.RequestModel;

namespace University.Blazor.Application.Mappings.LinkMapping;

public class LinkMappingProfile : Profile
{
    public LinkMappingProfile()
    {
        CreateMap<LinkModel, UpdateLinkRequestModel>()
            .ReverseMap();

        CreateMap<LinkModel, LinkViewModel>()
           .ReverseMap();
    }

}