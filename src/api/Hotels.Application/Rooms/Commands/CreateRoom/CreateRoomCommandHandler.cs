using AutoMapper;
using Hotels.Domain.Entities;
using Hotels.Domain.Repositories;
using MediatR;

namespace Hotels.Application.Rooms.Commands.CreateRoom;

public class CreateRoomCommandHandler(IRepository<Room> roomRepository,IMapper mapper) : IRequestHandler<CreateRoomCommand>
{
    public async Task Handle(CreateRoomCommand request, CancellationToken cancellationToken)
    {
        var room=mapper.Map<Room>(request);
        await roomRepository.Create(room);
        await roomRepository.SaveChanges();
    } 
}