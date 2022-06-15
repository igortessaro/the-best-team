using Microsoft.AspNetCore.Mvc;
using Pokemon.TheBestTeam.Domain.CQRS.Queries;
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
        public async Task<IActionResult> GetAllAsync(int id)
        {
            var result = await this._repository.GetAllByTrainerIdAsync(id);

            return this.Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(CollectionSummaryQuery collection)
        {
            var result = await this._repository.AddAsync(collection);

            return this.Ok(result);
        }
    }
}