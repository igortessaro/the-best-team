using Microsoft.AspNetCore.Mvc;
using Pokemon.TheBestTeam.Domain.CQRS.Commands;
using Pokemon.TheBestTeam.Domain.Repositories;

namespace Pokemon.TheBestTeam.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokedexController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromServices] IPokedexRepository pokedexRepository, [FromBody] AddPokemonOnPokedexCommand command)
    {
        await pokedexRepository.AddAsync(command);

        return Ok("The pokemon was successfully added to the pokedex");
    }
}
