using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Application.Features.Queries.ViewModels;

namespace University.Application.Features.Queries.GetLinkById
{
    public class GetSectionByIdQuery : IRequest<SectionViewModel>
    {
        public string Id { get; set; }

        public GetSectionByIdQuery(string id)
        {
            Id = id;
        }
    }


}
