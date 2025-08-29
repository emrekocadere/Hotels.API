using AutoMapper;
using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Hotels.Commands.CreateHotel;

public class CreateHotelCommandHandler(IMapper mapper, IRepository<Hotel> hotelsRepository)
    : IRequestHandler<CreateHotelCommand, bool>
{
    public async Task<bool> Handle(CreateHotelCommand request, CancellationToken cancellationToken)
    {
        var hotel = mapper.Map<Hotel>(request);
        hotelsRepository.Create(hotel);
        var affectedRows= await hotelsRepository.SaveChanges();
        if (affectedRows > 0)
            return true;
        else
        {
            return false;
        }
       
    }
}