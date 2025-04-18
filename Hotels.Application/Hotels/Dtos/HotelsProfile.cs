using AutoMapper;
using Hotels.Domain.Entities;

namespace Hotels.Application.Hotels.Dtos;

public class HotelsProfile:Profile
{
    public HotelsProfile()
    {
        CreateMap<CreateHotelDto, Hotel>()
            .ForMember(d => d.Address,opt=>opt
                .MapFrom(src=>new Address
                {
                    City = src.City,
                     Country = src.Country,
                     PostalCode = src.PostalCode
                     
                }));
        
        CreateMap<Hotel, HotelDto>()
            .ForMember(d=>d.City, opt => opt.MapFrom(src=>src.Address.City))
            .ForMember(d=>d.Country, opt => opt.MapFrom(src=>src.Address.Country))
            .ForMember(d=>d.PostalCode, opt => opt.MapFrom(src=>src.Address.PostalCode));
    }
}