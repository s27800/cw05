namespace cw05.Models;

public class Appointment
{
    public string Date { get; set; }
    public Animal Animal1 { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

    public Appointment(string date, Animal animal1, string description, int price)
    {
        Date = date;
        Animal1 = animal1;
        Description = description;
        Price = price;
    }
}