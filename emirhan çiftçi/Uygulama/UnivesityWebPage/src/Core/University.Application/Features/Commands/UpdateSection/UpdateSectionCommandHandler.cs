using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Interfaces.Repositories;
using University.Domain.Models;

namespace University.Application.Features.Commands.UpdateLink
{
    public class UpdateSectionCommandHandler : IRequestHandler<UpdateSectionCommand, bool>
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly IMapper _mapper;

        public UpdateSectionCommandHandler(ISectionRepository sectionRepository, IMapper mapper)
        {
            _sectionRepository = sectionRepository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateSectionCommand request, CancellationToken cancellationToken)
        {
            await ProcessLink(request.UpdateLinkDTO, cancellationToken);
            return true;
        }

        private async Task ProcessLink(UpdateSectionDTO sectionDTO, CancellationToken cancellationToken)
        {
            var section = await _sectionRepository.GetById(Guid.Parse(sectionDTO.Id));

            _mapper.Map(sectionDTO, section);

            _sectionRepository.Update(section);
            
            await _sectionRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        }
    }
}
