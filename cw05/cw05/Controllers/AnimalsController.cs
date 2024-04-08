using cw05.Database;
using cw05.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw05.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    private static readonly AnimalsDB _animalsDB = new();
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(_animalsDB.Animals);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animalsDB.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
            return NotFound($"Animal with id={id} was not found");
        
        return Ok(animal);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = _animalsDB.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
            return NotFound($"Animal with id={id} was not found");

        _animalsDB.Animals.Remove(animal);
        return NoContent();
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        _animalsDB.Animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
    
    [HttpPost("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var oldAnimal = _animalsDB.Animals.FirstOrDefault(a => a.Id == id);
        if (oldAnimal == null)
            return NotFound($"Animal with id={id} was not found");

        _animalsDB.Animals.Remove(oldAnimal);
        _animalsDB.Animals.Add(animal);
        
        return NoContent();
    }
}