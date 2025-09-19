using Hotels.Domain.Entities;
using MediatR;

namespace Hotels.Application.Hotels.Commands.CreateHotel;

public class CreateHotelCommand : IRequest<int>
{
    public  string Name { get; set; }
    public  short Star { get; set; }
    public  string ContactEmail { get; set; }
    public  string ContactNumber { get; set; }
    public  int CityId { get; set; }
    public TimeOnly CheckInTime { get; set; }
    public TimeOnly CheckOutTime { get; set; }
    public ICollection<int>? FeatureIds { get; set; }

}





