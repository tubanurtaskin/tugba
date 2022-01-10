using AutoMapper;
using MediatR;
using University.Application.Interfaces.Repositories;
using University.Domain.Models;

namespace University.Application.Features.Commands.CreateLink;

public class CreateSectionCommandHandler : IRequestHandler<CreateLinkCommand, bool>
{
    private readonly ILinkRepository _linkRepository;
    private readonly IMapper _mapper;

    public CreateSectionCommandHandler(ILinkRepository linkRepository, IMapper mapper)
    {
        _linkRepository = linkRepository;
        _mapper = mapper;
    }

    public async Task<bool> Handle(CreateLinkCommand request, CancellationToken cancellationToken)
    {
        await ProcessLink(request.LinkDTO,cancellationToken); 
        return true;
    }

    private async Task ProcessLink(LinkDTO linkDTO, CancellationToken cancellationToken)
    {
        var link = _mapper.Map<Link>(linkDTO);
        var result =await _linkRepository.AddAsync(link);
        
        await _linkRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        
    }

}