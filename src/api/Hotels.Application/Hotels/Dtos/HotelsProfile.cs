using AutoMapper;
using Hotels.Application.Hotels.Commands.AddReviewToHotel;
using Hotels.Application.Hotels.Commands.CreateHotel;
using Hotels.Domain.Entities;

namespace Hotels.Application.Hotels.Dtos;

public class HotelsProfile : Profile
{
    public HotelsProfile()
    {
        CreateMap<CreateHotelCommand, Hotel>().ReverseMap();
        // .ForMember(d => d.Id,opt=>opt
        //     .MapFrom(src=>new Address
        //     {
        //          City = src.City,
        //          Country = src.Country,
        //          PostalCode = src.PostalCode
        //          
        //     }));

        CreateMap<Hotel, HotelDto>();
        
        CreateMap<AddReviewToHotelCommand, Review>();

            CreateMap<Review, ReviewDto>();
    }
}