using AutoMapper;
using Hotels.Domain.Entities;

namespace Hotels.Application.Hotels.Dtos;

public class HotelWithRoomsProfile:Profile
{
    public HotelWithRoomsProfile()
    {
        CreateMap<Hotel, HotelWithRoomsDto>()
            .ForMember(d=>d.City, opt => opt.MapFrom(src=>src.Address.City))
            .ForMember(d=>d.Country, opt => opt.MapFrom(src=>src.Address.Country))
            .ForMember(d=>d.PostalCode, opt => opt.MapFrom(src=>src.Address.PostalCode))
            .ForMember(d=>d.Rooms, opt => opt.MapFrom(src=>src.Rooms));;

    }
}