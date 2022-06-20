using Microsoft.AspNetCore.Mvc;
using Pokemon.TheBestTeam.Domain.CQRS.Queries;
using Pokemon.TheBestTeam.Domain.Repositories;


namespace Pokemon.TheBestTeam.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository _repository;

        public PokemonController(IPokemonRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllAsync(int id)
        {
            var result = await this._repository.GetAllByIdAsync(id);

            return this.Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(PokemonSummaryQuery pokemon)
        {
            var result = await this._repository.AddAsync(pokemon);

            return this.Ok(result);
        }
    }
}