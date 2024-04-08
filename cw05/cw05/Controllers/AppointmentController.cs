using cw05.Database;
using cw05.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw05.Controllers;

[ApiController]
[Route("[controller]")]
public class AppointmentController : ControllerBase
{
    [HttpGet("{id:int}")]
    public IActionResult GetAppointmentsForAnimal(int id)
    {
        var animal = AnimalsDB.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
            return NotFound($"Animal with id={id} was not found");
        
        return Ok(AppointmentDB.GetAppointmentsForAnimal(animal));
    }

    [HttpPost]
    public IActionResult CreateAppointment(Appointment appointment)
    {
        var animal = AnimalsDB.Animals.FirstOrDefault(a => a.Id == appointment.Animal1.Id);
        if (animal == null)
            AnimalsDB.Animals.Add(appointment.Animal1);
        else if (animal != appointment.Animal1)
        {
            AnimalsDB.Animals.Remove(animal);
            AnimalsDB.Animals.Add(appointment.Animal1);
        }
        
        AppointmentDB.Appointments.Add(appointment);
        return StatusCode(StatusCodes.Status201Created);
    }
}