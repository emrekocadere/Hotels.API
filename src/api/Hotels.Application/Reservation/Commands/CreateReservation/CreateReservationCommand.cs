using Hotels.Application.Common;
using MediatR;

namespace Hotels.Application.Reservation.Commands.CreateReservation;

public class CreateReservationCommand: IRequest<Result>
{
    public DateOnly CheckIn { get; set; }
    public DateOnly CheckOut { get; set; }
    public int RoomId { get; set; }
    
}