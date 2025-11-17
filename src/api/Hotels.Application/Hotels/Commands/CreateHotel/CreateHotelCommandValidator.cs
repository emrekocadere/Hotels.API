using FluentValidation;
using Hotels.Application.Hotels.Commands.CreateHotel;
using Hotels.Application.Hotels.Dtos;

namespace Hotels.Application.Hotels.Validators;

public class CreateHotelCommandValidator : AbstractValidator<CreateHotelCommand>
{
    public CreateHotelCommandValidator()
    {
        RuleFor(x => x.Name).Length(3, 100).NotEmpty();
        RuleFor(x => x.ContactEmail).EmailAddress();


        RuleFor(x => x.Name)
            .Custom((value, context) =>
            {
                var isStartE = value.StartsWith("E");
                if (isStartE)
                    context.AddFailure("isim 'E' ile baslayamaz");
            });


        // RuleFor(x => x.Star).ınc(0,5).WithMessage("Star must be greater than 5");
    }
}