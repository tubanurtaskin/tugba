using AutoMapper;
using MediatR;
using University.Application.Interfaces.Repositories;

namespace University.Application.Features.Commands.DeleteLink
{
    public class DeleteLinkCommandHandler : IRequestHandler<DeleteLinkCommand, bool>
    {
        private readonly ILinkRepository _linkRepository;
        private readonly IMapper _mapper;

        public DeleteLinkCommandHandler(ILinkRepository linkRepository, IMapper mapper)
        {
            _linkRepository = linkRepository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteLinkCommand request, CancellationToken cancellationToken)
        {
            var id = Guid.Parse(request.Id);
            _linkRepository.Delete(id);
            
            var result = await _linkRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
            
            return result;
        }
    }


}
