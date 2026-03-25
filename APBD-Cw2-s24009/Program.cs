
using APBD_Cw2_s24009.Models;
using APBD_Cw2_s24009.Services.Reservations;
using APBD_Cw2_s24009.Services.Tools;

var employee = new Employee("Sheev", "Palpatine");
var student = new Student("Anakin", "Skywalker");

var camera = new Camera("Zenit", 180.5f, "900x600");
var soundSystem = new SoundSystem("Blaupunkt", "Lapel microphone", true);
var laptop = new Laptop("Asus ROG", "Windows XP", false);

IToolService toolService = new ToolService();

toolService.AddTool(camera);
toolService.AddTool(soundSystem);
toolService.AddTool(laptop);

toolService.SetUnavailable(soundSystem.Id);

IReservationService reservationService = new ReservationService();

try
{
    Console.WriteLine("\nPróba reserwacji sprzętu, który nie jest dostępny");
    reservationService.CreateReservation(
        employee,
        soundSystem,
        new DateTime(2026, 1, 1, 10, 0, 0),
        new DateTime(2026, 1, 1, 11, 30, 0));
}
catch (Exception e)
{
    Console.WriteLine("Przedmiot jest niedostępny");
}

try
{
    Console.WriteLine("\nPróba reserwacji sprzętu, który już został wypożyczony");
    reservationService.CreateReservation(
        student,
        toolService.GetToolById(1),
        new DateTime(2026, 1, 1, 10, 0, 0),
        new DateTime(2026, 1, 1, 11, 30, 0));
    reservationService.CreateReservation(
        student,
        camera,
        new DateTime(2026, 1, 1, 10, 0, 0),
        new DateTime(2026, 1, 1, 11, 30, 0));
}
catch (Exception e)
{
    Console.WriteLine("Ten sprzęt został już wypożyczony");
}

try
{
    Console.WriteLine("\nPróba anulowania nieistniejącej rezerwacji");
    reservationService.CancelReservation(10);
}
catch (Exception e)
{
    Console.WriteLine("Nie ma takiej rezerwacji");
}

try
{
    Console.WriteLine("\nPróba pobrania nieistniejącego sprzętu");
    var tool = toolService.GetToolById(10);
}
catch (Exception e)
{
    Console.WriteLine("Przedmiot nie istnieje");
}
