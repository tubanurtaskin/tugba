using AutoMapper;
using MediatR;
using University.Application.Features.Queries.ViewModels;
using University.Application.Interfaces.Repositories;

namespace University.Application.Features.Queries.GetAllLink;

public class GetAllSectionQueryHandler : IRequestHandler<GetAllSectionQuery, List<SectionViewModel>>
{
    private readonly ISectionRepository _sectionRepository;
    private readonly IMapper _mapper;

    public GetAllSectionQueryHandler(ISectionRepository sectionRepository,IMapper mapper)
    {
        _sectionRepository = sectionRepository;
        _mapper = mapper;
    }

    public async Task<List<SectionViewModel>> Handle(GetAllSectionQuery request, CancellationToken cancellationToken)
    {
        var links = await _sectionRepository.Get(request.Predicate);
        var result = _mapper.Map<List<SectionViewModel>>(links);
        return result;
    }
}