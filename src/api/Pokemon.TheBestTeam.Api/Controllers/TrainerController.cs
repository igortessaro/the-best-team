using Microsoft.AspNetCore.Mvc;

namespace Pokemon.TheBestTeam.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TrainerControler : ControllerBase
{
    private readonly IHttpClientFactory _httpClientFactory;

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok("Will be implemented");
    }

    [HttpGet("{id}")]
    public IActionResult GetTrainer(string uuid)
    {
        return Ok("Will be implemented");
    }

    [HttpPost]
    public IActionResult CreateTrainer(Models.NewDrinkModel drink)
    {
        return Ok("Will be implemented");
    }

    [HttpPut("{id}")]
    public IActionResult UpdateTrainer(string uuid, object drink)
    {
        return Ok("Will be implemented");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTrainer(string uuid)
    {
        return Ok("Will be implemented");
    }
}
