using AutoMapper;
using Hotels.Application.Common;
using Hotels.Domain.Repositories;
using MediatR;
using IUserContext = Hotels.Application.Common.IUserContext;

namespace Hotels.Application.Reservation.Commands.CreateReservation;

public class CreateReservationCommandHandler(
    IRepository<Domain.Entities.Reservation> reservationRepository,
    IMapper mapper,
    IUserContext userContext)
    : IRequestHandler<CreateReservationCommand, Result>
{
    public async Task<Result> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
    {
        var currentUserId = userContext.UserId;
        var reservation = mapper.Map<Domain.Entities.Reservation>(request);
        
        reservation.UserId = currentUserId;
        await reservationRepository.Create(reservation);
        
        var affectedRows=await reservationRepository.SaveChanges();

        if (affectedRows > 0)
            return Result.Success();
        else
            return Error.DatabaseSaveError;



    }
}