using cw05.Database;
using cw05.Models;

namespace cw05.Endpoints;

public static class AnimalMappings
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapPost("/animals", (Animal animal) =>
        {
            MockDB.AddAnimal(animal);
        });

        app.MapDelete("/animals", (int id) =>
        {
            MockDB.RemoveAnimal(id);
        });
    }
}