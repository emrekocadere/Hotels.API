using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Hotels.Commands.DeleteHotel;

public class DeleteHotelCommandHandler(IHotelsRepository hotelsRepository):IRequestHandler<DeleteHotelCommand,bool>
{
    public async Task<bool> Handle(DeleteHotelCommand request, CancellationToken cancellationToken)
    {
        var hotel =await hotelsRepository.GetByIdAsync(request.Id);
        if (hotel is null)
            return false;
        
        await hotelsRepository.Delete(hotel);
        return true;

    }
}