using cw05.Models;

namespace cw05.Database;

public class AppointmentDB
{
    public static List<Appointment> Appointments { get; set; } = new();

    public static List<Appointment> GetAppointmentsForAnimal(Animal animal)
    {
        List<Appointment> list = new();
        
        foreach (var appointment in Appointments)
        {
            if(appointment.Animal1 == animal)
                list.Add(appointment);
        }

        return list;
    }
}