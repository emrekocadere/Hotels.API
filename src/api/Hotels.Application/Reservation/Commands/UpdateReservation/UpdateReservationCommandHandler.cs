using Hotels.Application.Common;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Reservation.Commands.UpdateReservation;

public class UpdateReservationCommandHandler(
    IReservationRepository reservationRepository
    )
    :IRequestHandler<UpdateReservationCommand, Result>
{
    public async Task<Result> Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
    {
        var reservation=await reservationRepository.GetByIdAsync(request.ReservationId);
        reservation.CheckIn=request.CheckIn;
        reservation.CheckOut=request.CheckOut;
        return Result.Success();
    }
}