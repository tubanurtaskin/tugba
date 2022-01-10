using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Application.Features.Commands.DeleteLink
{
    public class DeleteLinkCommand : IRequest<bool>
    {
        public string Id { get; set; }

        public DeleteLinkCommand(string ıd)
        {
            Id = ıd;
        }
    }


}
