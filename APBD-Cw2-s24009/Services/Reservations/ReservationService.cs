using APBD_Cw2_s24009.Enums;
using APBD_Cw2_s24009.Models;

namespace APBD_Cw2_s24009.Services.Reservations;

public class ReservationService : IReservationService
{
    private readonly List<Reservation> _reservations = [];

    public void CreateReservation(User user, WorkTool workTool, DateTime from, DateTime to)
    {
        if (workTool.Status != ToolStatus.Available)
        {
            throw new Exception("Pokój jest niedostępny\n");
        }

        int activeUserReservations = _reservations.Count(reservation =>
            !reservation.IsCancelled
            && reservation.User == user);

        if (activeUserReservations >= user.GetMaxReservations())
        {
            throw new Exception("Za dużo rezerwacji\n");
        }

        bool reservationConflict = _reservations.Any(reservation =>
            !reservation.IsCancelled
            && reservation.WorkTool == workTool
            && reservation.Overlaps(from, to));

        if (reservationConflict)
        {
            throw new Exception("Data jest nieprawidłowa\n");
        }

        var newReservation = new Reservation(workTool, user, from, to);
        _reservations.Add(newReservation);
    }

    public void CancelReservation(int reservationId)
    {
        var reservation = _reservations.Find(reservation => reservation.Id == reservationId);
    }

    public List<Reservation> GetUserReservations(User user)
    {
        return _reservations.Where(reservation => reservation.User == user && !reservation.IsCancelled).ToList();
    }

    public List<Reservation> GetAll()
    {
        return _reservations;
    }
}