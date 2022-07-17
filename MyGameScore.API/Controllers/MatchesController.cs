using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyGameScore.Application.Commands.CreateMatch;
using MyGameScore.Application.Queries.GetAllMatches;
using MyGameScore.Application.Queries.GetMatchById;

namespace MyGameScore.API.Controllers
{
    [Route("api/matches")]
    [Authorize]
    public class MatchesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MatchesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // api/matches
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var getAllMatchesQuery = new GetAllMatchesQuery();

            var matches = await _mediator.Send(getAllMatchesQuery);

            return Ok(matches);
        }

        // api/matches/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetMatchByIdQuery(id);

            var match = await _mediator.Send(query);

            if (match == null) return NotFound();

            return Ok(match);
        }

        // api/matches
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateMatchCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }
    }
}
