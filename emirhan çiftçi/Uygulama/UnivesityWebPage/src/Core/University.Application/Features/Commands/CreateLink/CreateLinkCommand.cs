using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Application.Features.Commands.CreateLink
{
    public class CreateLinkCommand : IRequest<bool>
    {
        public LinkDTO? LinkDTO { get; set; }
    }


    public class LinkDTO
    {
        public LinkDTO(string name, string href, bool isNode, string? linkId)
        {
            Name = name;
            Href = href;
            IsNode = isNode;
            LinkId = !string.IsNullOrEmpty(linkId) && IsNode ? throw new Exception("This link is Node,you doesn't set linkid") : linkId;
        }
        public string Name { get; set; }
        public string Href { get; set; }
        public bool IsNode { get; set; } = false;
        public string? LinkId { get; set; }
    }
}
