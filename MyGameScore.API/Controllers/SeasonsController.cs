using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyGameScore.Application.Commands.CreateSeason;
using MyGameScore.Application.Queries.GetSeasonById;
using MyGameScore.Application.Queries.GetSeasonStats;

namespace MyGameScore.API.Controllers
{
    [Route("api/seasons")]
    [Authorize]
    public class SeasonsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SeasonsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // api/seasons/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetSeasonByIdQuery(id);

            var season = await _mediator.Send(query);

            if (season == null) return NotFound();

            return Ok(season);
        }

        // api/seasons
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateSeasonCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        // api/seasons/1/stats
        [HttpGet("{id}/stats")]
        public async Task<IActionResult> GetStats(int id)
        {
            var query = new GetSeasonStatsQuery(id);

            var stats = await _mediator.Send(query);

            if (stats == null) return NotFound();

            return Ok(stats);
        }
    }
}