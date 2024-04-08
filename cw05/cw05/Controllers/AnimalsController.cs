using cw05.Database;
using cw05.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw05.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(AnimalsDB.Animals);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = AnimalsDB.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
            return NotFound($"Animal with id={id} was not found");
        
        return Ok(animal);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = AnimalsDB.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
            return NotFound($"Animal with id={id} was not found");

        AnimalsDB.Animals.Remove(animal);
        return NoContent();
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        AnimalsDB.Animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
    
    [HttpPost("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var oldAnimal = AnimalsDB.Animals.FirstOrDefault(a => a.Id == id);
        if (oldAnimal == null)
            return NotFound($"Animal with id={id} was not found");

        AnimalsDB.Animals.Remove(oldAnimal);
        AnimalsDB.Animals.Add(animal);
        
        return NoContent();
    }
}