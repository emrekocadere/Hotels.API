using AutoMapper;
using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Hotels.Commands.CreateHotel;

public class CreateHotelCommandHandler(IMapper mapper, IRepository<Hotel> hotelsRepository)
    : IRequestHandler<CreateHotelCommand, int>
{
    public async Task<int> Handle(CreateHotelCommand request, CancellationToken cancellationToken)
    {
        var hotel = mapper.Map<Hotel>(request); 
        await hotelsRepository.Create(hotel);
        var affectedRows= await hotelsRepository.SaveChanges();
        if (affectedRows > 0)
            return hotel.Id;
        else
        {
            return hotel.Id;
        }

    }
}


