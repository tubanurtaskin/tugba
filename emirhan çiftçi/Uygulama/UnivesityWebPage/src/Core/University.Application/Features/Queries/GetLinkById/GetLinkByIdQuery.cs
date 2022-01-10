using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Features.Queries.ViewModels;

namespace University.Application.Features.Queries.GetLinkById
{
    public class GetLinkByIdQuery : IRequest<LinkViewModel>
    {
        public string Id { get; set; }

        public GetLinkByIdQuery(string id)
        {
            Id = id;
        }
    }


}
