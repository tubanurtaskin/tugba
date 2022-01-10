using System.Linq.Expressions;
using MediatR;
using University.Application.Features.Queries.ViewModels;
using University.Domain.Models;

namespace University.Application.Features.Queries.GetAllLink;

public class GetAllSectionQuery : IRequest<List<SectionViewModel>>
{
    public Expression<Func<Section,bool>> Predicate { get; set; }
}
