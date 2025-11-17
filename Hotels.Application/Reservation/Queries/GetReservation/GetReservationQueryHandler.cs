using AutoMapper;
using Hotels.Application.Common;
using Hotels.Application.Reservation.Dtos;
using Hotels.Domain.Repositories;
using MediatR;
using IUserContext = Hotels.Application.Common.IUserContext;

namespace Hotels.Application.Reservation.Queries.GetReservation;

public class GetReservationQueryHandler(
    IMapper mapper,
    IReservationRepository reservationRepository,
    IUserContext userContext
    )
    :IRequestHandler<GetReservationQuery,ResultT<IList<ReservationDto>>>
{
    public async Task<ResultT<IList<ReservationDto>>> Handle(GetReservationQuery request, CancellationToken cancellationToken)
    {
        var currentUserId=userContext.UserId;

        var reservations= reservationRepository.GetReservationByUserId(currentUserId);
        
        var reservationDtos = mapper.Map<ICollection<ReservationDto>>(reservations);

        return reservationDtos.ToList();
    }
}