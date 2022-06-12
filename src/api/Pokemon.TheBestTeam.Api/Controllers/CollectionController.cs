using Microsoft.AspNetCore.Mvc;
using Pokemon.TheBestTeam.Domain.Repositories;


namespace Pokemon.TheBestTeam.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CollectionController : ControllerBase
    {
        private readonly ICollectionRepository _repository;

        public CollectionController(ICollectionRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllPokemonsAsync(int id)
        {
            var result = await this._repository.GetAllByTrainerIdAsync(id);

            return this.Ok(result);
        }
    }
}