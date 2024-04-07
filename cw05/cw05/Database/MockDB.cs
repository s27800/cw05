using cw05.Models;

namespace cw05.Database;

public class MockDB
{
    public static List<Animal> Animals { get; set; } = new List<Animal>();

    public static void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public static void RemoveAnimal(int id)
    {
        for (int i = 0; i < Animals.Count; i++)
        {
            Animal animal = Animals[i];
            
            if (animal.Id == id)
            {
                Animals.Remove(animal);
            }
        }
    }
}