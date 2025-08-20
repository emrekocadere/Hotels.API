using Hotels.Application.Hotels.Dtos;
using MediatR;

namespace Hotels.Application.Hotels.Queries.GetHotelById;

public class GetHotelByIdQuery(int id) : IRequest<HotelDto?>
{
    public int Id { get; set; } = id;
}