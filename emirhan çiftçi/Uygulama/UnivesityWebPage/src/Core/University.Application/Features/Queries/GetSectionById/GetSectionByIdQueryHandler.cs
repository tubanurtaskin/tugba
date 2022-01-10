using AutoMapper;
using MediatR;
using University.Application.Features.Queries.ViewModels;
using University.Application.Interfaces.Repositories;

namespace University.Application.Features.Queries.GetLinkById
{
    public class GetSectionByIdQueryHandler : IRequestHandler<GetSectionByIdQuery, SectionViewModel>
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly IMapper _mapper;

        public GetSectionByIdQueryHandler(ISectionRepository sectionRepository, IMapper mapper)
        {
            _sectionRepository = sectionRepository;
            _mapper = mapper;
        }
        public async Task<SectionViewModel> Handle(GetSectionByIdQuery request, CancellationToken cancellationToken)
        {
            var links = await _sectionRepository.GetById(Guid.Parse(request.Id));
            var result = _mapper.Map<SectionViewModel>(links);
            return result;
        }
    }


}
