using AutoMapper;
using Hotels.Application.Reservation.Commands.CreateReservation;

namespace Hotels.Application.Reservation.Dtos;

public class ReservationProfile:Profile
{
    public ReservationProfile()
    {
        CreateMap<CreateReservationCommand, Domain.Entities.Reservation>().ReverseMap();
        CreateMap<Domain.Entities.Reservation, ReservationDto>();
    }
}