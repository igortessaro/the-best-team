using Microsoft.AspNetCore.Mvc;
using Pokemon.TheBestTeam.Api.Models;
using Pokemon.TheBestTeam.Domain.Repositories;

namespace Pokemon.TheBestTeam.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CollectionController : ControllerBase
{
    private readonly ILogger<CollectionController> _logger;
    private readonly ITrainerPokemonCollectionRepository _collectionRepository;

    public CollectionController(ILogger<CollectionController> logger, ITrainerPokemonCollectionRepository collectionRepository)
    {
        _logger = logger;
        _collectionRepository = collectionRepository;
    }

    [HttpGet]
    public IEnumerable<TrainerPokemonCollection> GetAllPokemonsByTrainerId(int trainerId)
    {
        return _collectionRepository.GetAllPokemonsByTrainerId(trainerId);
    }
}
