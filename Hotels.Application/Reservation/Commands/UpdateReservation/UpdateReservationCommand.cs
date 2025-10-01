using Hotels.Application.Common;
using MediatR;

namespace Hotels.Application.Reservation.Commands.UpdateReservation;

public class UpdateReservationCommand:IRequest<Result>
{
    public DateOnly CheckIn { get; set; }
    public DateOnly CheckOut { get; set; }
    public int ReservationId { get; set; } 
}