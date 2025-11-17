using FluentValidation;

namespace Hotels.Application.Rooms.Commands.CreateRoom;

public class CreateRoomCommandValidator : AbstractValidator<CreateRoomCommand>
{
    public CreateRoomCommandValidator()
    {
        RuleFor(room => room.Price)
            .GreaterThan(0)
            .WithMessage("price must be greater than 0");
    }
}