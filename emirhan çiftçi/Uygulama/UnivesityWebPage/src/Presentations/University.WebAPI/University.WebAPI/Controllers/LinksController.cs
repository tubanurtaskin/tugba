using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Application.Features.Commands.CreateLink;
using University.Application.Features.Commands.DeleteLink;
using University.Application.Features.Commands.UpdateLink;
using University.Application.Features.Queries.GetAllLink;
using University.Application.Features.Queries.GetLinkById;
using University.Domain.Models;

namespace University.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LinksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LinksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateLink(LinkDTO linkDTO)
        {
            var createCommand = new CreateLinkCommand();

            createCommand.LinkDTO = linkDTO;
            
            var res = await _mediator.Send(createCommand);

            return Ok(res);
        }

        [HttpGet("[action]")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllLink(bool isJustNode = true)
        {
           
            var query = new GetAllLinkQuery();
            var res = await _mediator.Send(query);
            res = isJustNode ? res.Where(x => x.IsNode).ToList() : res;
            return Ok(res);
        }

        [HttpGet("[action]/{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(string id)
        {
            var query = new GetLinkByIdQuery(id);
            var res = await _mediator.Send(query);
            return Ok(res);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateLink(UpdateLinkDTO model)
        {
            var query = new UpdateLinkCommand(model);
            var res = await _mediator.Send(query);
            return Ok(res);
        }

        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> DeleteLink(string id)
        {
            var query = new DeleteLinkCommand(id);
            var res = await _mediator.Send(query);
            return Ok(res);
        }



    }
}
