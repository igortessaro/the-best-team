using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokemon.TheBestTeam.Domain.Repositories;

namespace Pokemon.TheBestTeam.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        private readonly ITrainerRepository _repository;

        public TrainerController(ITrainerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await this._repository.GetAllAsync();

            return this.Ok(result);
        }
    }
}
