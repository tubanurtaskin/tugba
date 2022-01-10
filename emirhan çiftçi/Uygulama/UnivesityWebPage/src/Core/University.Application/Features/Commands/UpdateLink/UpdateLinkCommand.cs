using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Application.Features.Commands.UpdateLink
{
    public class UpdateLinkCommand : IRequest<bool>
    {
        public UpdateLinkDTO UpdateLinkDTO { get; set; }

        public UpdateLinkCommand(UpdateLinkDTO updateLinkDTO)
        {
            UpdateLinkDTO = updateLinkDTO;
        }
    }

    public class UpdateLinkDTO
    {
        public UpdateLinkDTO(string id, string name, string href)
        {
            Name = name;
            Href = href;
            Id = id;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }
    }

}
