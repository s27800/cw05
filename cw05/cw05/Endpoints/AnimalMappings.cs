using cw05.Models;

namespace cw05.Endpoints;

public static class AnimalMappings
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapPost("/animals", (Animal animal, int id) =>
        {
    
        });
    }
}