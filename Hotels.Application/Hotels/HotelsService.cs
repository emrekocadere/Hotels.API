using AutoMapper;
using Hotels.Application.Hotels.Dtos;
using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;

namespace Hotels.Application.Hotels;

public class HotelsService(IHotelsRepository hotelsRepository,IMapper mapper) : IHotelsService
{
    public async Task<IEnumerable<HotelDto>> GetAllHotelsAsync()
    {
        var hotels = await hotelsRepository.GetAllAsync();
        
        var hotelsDtos=mapper.Map<IEnumerable<HotelDto>>(hotels);
        
        return hotelsDtos;
    }

    // public async Task<HotelDto?> GetById(int id)
    // {
    //     var hotel = await hotelsRepository.GetByIdAsync( id);
    //     return hotel;
    // }

}