using System.Linq.Expressions;
using MediatR;
using University.Application.Features.Queries.ViewModels;
using University.Domain.Models;

namespace University.Application.Features.Queries.GetAllLink;

public class GetAllLinkQuery : IRequest<List<LinkViewModel>>
{
    public Expression<Func<Link,bool>> Predicate { get; set; }
}
