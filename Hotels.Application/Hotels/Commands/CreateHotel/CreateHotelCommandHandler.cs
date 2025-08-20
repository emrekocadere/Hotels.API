using AutoMapper;
using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Hotels.Commands.CreateHotel;

public class CreateHotelCommandHandler(IMapper mapper,IHotelsRepository hotelsRepository ):IRequestHandler<CreateHotelCommand,int>
{
    public async Task<int> Handle(CreateHotelCommand request, CancellationToken cancellationToken)
    {
        var hotel = mapper.Map<Hotel>(request);
        int id = await hotelsRepository.Create(hotel);
        return id;
    }
}