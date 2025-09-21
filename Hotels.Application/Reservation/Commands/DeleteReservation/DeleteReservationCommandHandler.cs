using Hotels.Application.Common;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Reservation.Commands.DeleteReservation;

public class DeleteReservationCommandHandler(
    IReservationRepository reservationRepository
    ):IRequestHandler<DeleteReservationCommand,Result>
{
    public async Task<Result> Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
    {
        var reservation = await reservationRepository.GetByIdAsync(request.ReservationId);
        reservation.IsCanceled = true;
        var affectedRows= await reservationRepository.SaveChanges();

        return Result.Success();
 
    }
}