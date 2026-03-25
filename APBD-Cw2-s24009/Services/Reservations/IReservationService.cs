using APBD_Cw2_s24009.Models;

namespace APBD_Cw2_s24009.Services.Reservations;

public interface IReservationService
{
    public void CreateReservation(User user, WorkTool workTool, DateTime from, DateTime to);
    public void CancelReservation(int reservationId);
    public List<Reservation> GetUserReservations(User user);
    public List<Reservation> GetAll();
}