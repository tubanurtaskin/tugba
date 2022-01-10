using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Application.Features.Commands.UpdateLink
{
    public class UpdateSectionCommand : IRequest<bool>
    {
        public UpdateSectionDTO UpdateLinkDTO { get; set; }

        public UpdateSectionCommand(UpdateSectionDTO updateLinkDTO)
        {
            UpdateLinkDTO = updateLinkDTO;
        }
    }

    public class UpdateSectionDTO
    {
        public UpdateSectionDTO(string id,string name, string content, int priority)
        {
            Id = id;
            Name = name;
            Content = content;
            Priority = priority;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int Priority { get; set; }
    }

}
