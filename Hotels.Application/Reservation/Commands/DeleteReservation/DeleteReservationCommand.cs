using Hotels.Application.Common;
using MediatR;

namespace Hotels.Application.Reservation.Commands.DeleteReservation;

public class DeleteReservationCommand:IRequest<Result>
{
    public int ReservationId { get; set; }
}