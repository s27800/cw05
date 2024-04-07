using cw05.Database;
using Microsoft.AspNetCore.Mvc;

namespace cw05.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = MockDB.Animals;
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal()
    {
        return Ok();
    }
}