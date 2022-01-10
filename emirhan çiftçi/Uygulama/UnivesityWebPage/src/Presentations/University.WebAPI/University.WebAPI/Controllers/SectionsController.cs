using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using University.Application.Features.Commands.CreateSection;
using University.Application.Features.Commands.DeleteLink;
using University.Application.Features.Commands.UpdateLink;
using University.Application.Features.Queries.GetAllLink;
using University.Application.Features.Queries.GetLinkById;

namespace University.WebAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
[Authorize]
public class SectionsController : ControllerBase
{
    private readonly IMediator _mediator;

    public SectionsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateSection(SectionDTO SectionDTO)
    {
        var createCommand = new CreateSectionCommand();

        createCommand.SectionDTO = SectionDTO;

        var res = await _mediator.Send(createCommand);

        return Ok(res);
    }

    [HttpGet("[action]")]
    [AllowAnonymous]
    public async Task<IActionResult> GetAllSection()
    {

        var query = new GetAllSectionQuery();
        var res = await _mediator.Send(query);
        res.OrderBy(x => x.Priority);
        return Ok(res);
    }

    [HttpGet("[action]/{id}")]
    [AllowAnonymous]
    public async Task<IActionResult> GetById(string id)
    {
        var query = new GetSectionByIdQuery(id);
        var res = await _mediator.Send(query);
        return Ok(res);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> UpdateSection(UpdateSectionDTO model)
    {
        var query = new UpdateSectionCommand(model);
        var res = await _mediator.Send(query);
        return Ok(res);
    }

    [HttpDelete("[action]/{id}")]
    public async Task<IActionResult> DeleteSection(string id)
    {
        var query = new DeleteSectionCommand(id);
        var res = await _mediator.Send(query);
        return Ok(res);
    }

}

