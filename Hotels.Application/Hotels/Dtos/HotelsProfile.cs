using AutoMapper;
using Hotels.Domain.Entities;

namespace Hotels.Application.Hotels.Dtos;

public class HotelsProfile:Profile
{
    public HotelsProfile()
    {
        CreateMap<Hotel, HotelDto>()
            .ForMember(d=>d.City, opt => opt.MapFrom(src=>src.Address.City))
            .ForMember(d=>d.Country, opt => opt.MapFrom(src=>src.Address.Country))
            .ForMember(d=>d.PostalCode, opt => opt.MapFrom(src=>src.Address.PostalCode));
    }
}