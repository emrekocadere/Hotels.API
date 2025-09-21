using AutoMapper;
using Hotels.Application.Reservation.Commands.CreateReservation;
using Hotels.Application.Rooms.Dtos;
using Hotels.Domain.Entities;

namespace Hotels.Application.Reservation.Dtos;

public class ReservationProfile:Profile
{
    public ReservationProfile()
    {
        CreateMap<CreateReservationCommand, Domain.Entities.Reservation>().ReverseMap();
        
        CreateMap<Domain.Entities.Reservation, ReservationDto>()
            .ForMember(d => d.Room, opt => opt
                .MapFrom(src => src.Room))
            .ForMember(d => d.HotelDetail, opt => opt
                .MapFrom(src => src.Room.Hotel));
        

    }
}