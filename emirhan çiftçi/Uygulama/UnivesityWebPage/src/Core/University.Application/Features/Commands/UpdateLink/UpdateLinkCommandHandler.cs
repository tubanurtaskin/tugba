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
    public class UpdateLinkCommandHandler : IRequestHandler<UpdateLinkCommand, bool>
    {
        private readonly ILinkRepository _linkRepository;
        private readonly IMapper _mapper;

        public UpdateLinkCommandHandler(ILinkRepository linkRepository, IMapper mapper)
        {
            _linkRepository = linkRepository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateLinkCommand request, CancellationToken cancellationToken)
        {
            await ProcessLink(request.UpdateLinkDTO, cancellationToken);
            return true;
        }

        private async Task ProcessLink(UpdateLinkDTO linkDTO, CancellationToken cancellationToken)
        {
            var link = await _linkRepository.GetById(Guid.Parse(linkDTO.Id));

            _mapper.Map(linkDTO, link);

            _linkRepository.Update(link);
            
            await _linkRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        }
    }
}
