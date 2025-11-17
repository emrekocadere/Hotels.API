using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Hotels.Commands.UpdateHotel;

public class UpdateHotelCommandHandler(IRepository<Hotel> hotelsRepository) : IRequestHandler<UpdateHotelCommand, bool>
{
    public async Task<bool> Handle(UpdateHotelCommand request, CancellationToken cancellationToken)
    {
        var hotel = await hotelsRepository.GetByIdAsync(request.Id);
        if (hotel is null)
            return false;

        await hotelsRepository.Delete(hotel);
        return true;
    }
}