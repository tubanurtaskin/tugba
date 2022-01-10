using AutoMapper;
using MediatR;
using University.Application.Features.Commands.CreateLink;
using University.Application.Interfaces.Repositories;
using University.Domain.Models;

namespace University.Application.Features.Commands.CreateSection;

public class CreateSectionCommandHandler : IRequestHandler<CreateSectionCommand, bool>
{
    private readonly ISectionRepository _sectionRepository;
    private readonly IMapper _mapper;

    public CreateSectionCommandHandler(ISectionRepository sectionRepository, IMapper mapper)
    {
        _sectionRepository = sectionRepository;
        _mapper = mapper;
    }

    public async Task<bool> Handle(CreateSectionCommand request, CancellationToken cancellationToken)
    {
        await ProcessLink(request.SectionDTO, cancellationToken);
        return true;
    }

    private async Task ProcessLink(SectionDTO sectionDTO, CancellationToken cancellationToken)
    {
        var section = _mapper.Map<Section>(sectionDTO);
        var result = await _sectionRepository.AddAsync(section);

        await _sectionRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

    }

}