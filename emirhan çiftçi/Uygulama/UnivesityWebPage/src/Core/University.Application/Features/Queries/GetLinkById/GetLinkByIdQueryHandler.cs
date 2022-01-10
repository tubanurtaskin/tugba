using AutoMapper;
using MediatR;
using University.Application.Features.Queries.ViewModels;
using University.Application.Interfaces.Repositories;

namespace University.Application.Features.Queries.GetLinkById
{
    public class GetLinkByIdQueryHandler : IRequestHandler<GetLinkByIdQuery, LinkViewModel>
    {
        private readonly ILinkRepository _linkRepository;
        private readonly IMapper _mapper;

        public GetLinkByIdQueryHandler(ILinkRepository linkRepository, IMapper mapper)
        {
            _linkRepository = linkRepository;
            _mapper = mapper;
        }
        public async Task<LinkViewModel> Handle(GetLinkByIdQuery request, CancellationToken cancellationToken)
        {
            var links = await _linkRepository.GetById(Guid.Parse(request.Id));
            var result = _mapper.Map<LinkViewModel>(links);
            return result;
        }
    }


}
