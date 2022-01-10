using AutoMapper;
using MediatR;
using University.Application.Features.Queries.ViewModels;
using University.Application.Interfaces.Repositories;

namespace University.Application.Features.Queries.GetAllLink;

public class GetAllLinkQueryHandler : IRequestHandler<GetAllLinkQuery,List<LinkViewModel>>
{
    private readonly ILinkRepository _linkRepository;
    private readonly IMapper _mapper;

    public GetAllLinkQueryHandler(ILinkRepository linkRepository,IMapper mapper)
    {
        _linkRepository = linkRepository;
        _mapper = mapper;
    }
    public async Task<List<LinkViewModel>> Handle(GetAllLinkQuery request, CancellationToken cancellationToken)
    {
        var links = await _linkRepository.Get(request.Predicate,i=>i.SubLinks);
        var result = _mapper.Map<List<LinkViewModel>>(links);
        return result;
    }
}