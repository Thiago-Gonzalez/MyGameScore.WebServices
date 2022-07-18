using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyGameScore.Application.Commands.CreatePlayer;
using MyGameScore.Application.Commands.LoginPlayer;
using MyGameScore.Application.Queries.GetPlayer;
using MyGameScore.Application.Queries.GetPlayerMatches;
using MyGameScore.Application.Queries.GetPlayerStats;

namespace MyGameScore.API.Controllers
{
    [Route("api/players")]
    [Authorize]
    public class PlayersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PlayersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // api/players/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetPlayerQuery(id);

            var player = await _mediator.Send(query);

            if (player == null) return NotFound();

            return Ok(player);
        }

        // api/players/1/stats
        [HttpGet("{id}/stats")]
        public async Task<IActionResult> GetStats(int id)
        {
            var query = new GetPlayerStatsQuery(id);

            var stats = await _mediator.Send(query);

            if (stats == null) return NotFound();

            return Ok(stats);
        }

        // api/players/1/matches
        [HttpGet("{id}/matches")]
        public async Task<IActionResult> GetPlayerMatches(int id)
        {
            var query = new GetPlayerMatchesQuery(id);

            var matches = await _mediator.Send(query);

            return Ok(matches);
        }

        // api/players
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Post([FromBody] CreatePlayerCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        // api/players/login
        [HttpPut("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginPlayerCommand command)
        {
            var loginPlayerViewModel = await _mediator.Send(command);

            if (loginPlayerViewModel == null) return BadRequest();

            return Ok(loginPlayerViewModel);
        }
    }
}
