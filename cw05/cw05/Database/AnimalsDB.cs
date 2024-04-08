using cw05.Models;

namespace cw05.Database;

public class AnimalsDB
{
    public List<Animal> Animals { get; set; } = new();

    public AnimalsDB()
    {
        Animals.Add(new Animal(
            1, "testName", "testCategory", 0, "testColor"
        ));
    }
}