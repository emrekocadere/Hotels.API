using Hotels.Application.Common;
using Hotels.Application.Reservation.Dtos;
using MediatR;

namespace Hotels.Application.Reservation.Queries.GetReservation;

public class GetReservationQuery:IRequest<ResultT<IList<ReservationDto>>>
{
   
}