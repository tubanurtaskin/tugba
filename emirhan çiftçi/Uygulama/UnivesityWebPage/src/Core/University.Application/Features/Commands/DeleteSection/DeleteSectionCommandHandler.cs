using AutoMapper;
using MediatR;
using University.Application.Interfaces.Repositories;

namespace University.Application.Features.Commands.DeleteLink
{
    public class DeleteSectionCommandHandler : IRequestHandler<DeleteSectionCommand, bool>
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly IMapper _mapper;

        public DeleteSectionCommandHandler(ISectionRepository sectionRepository, IMapper mapper)
        {
            _sectionRepository = sectionRepository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteSectionCommand request, CancellationToken cancellationToken)
        {
            var id = Guid.Parse(request.Id);
            _sectionRepository.Delete(id);
            
            var result = await _sectionRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
            
            return result;
        }
    }


}
