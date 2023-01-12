using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyGameScore.Application.Commands.CreateMatch;
using MyGameScore.Application.Commands.DeleteMatch;
using MyGameScore.Application.Commands.UpdateMatch;
using MyGameScore.Application.Queries.GetAllMatches;
using MyGameScore.Application.Queries.GetMatchById;
using MyGameScore.Application.Queries.GetTopHighScoreMatches;

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

        // api/matches/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] UpdateMatchCommand command) 
        {
            await _mediator.Send(command);

            return NoContent();
        }

        // api/matches/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) 
        {
            var command = new DeleteMatchCommand(id);

            await _mediator.Send(command);

            return NoContent();
        }

        // api/matches/tophighscorematches/10
        [HttpGet("tophighscorematches/{quantity}")]
        public async Task<IActionResult> GetTopHighScoreMatches(int quantity)
        {
            var query = new GetTopHighScoreMatchesQuery(quantity);

            var topMatches = await _mediator.Send(query);

            return Ok(topMatches);
        }
    }
}
