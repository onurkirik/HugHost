using FluentValidation;

namespace HugHost.Application.Commands.User.UpdateUser;

public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(d => d.User.UserName).NotNull().NotEmpty().WithMessage("UserName is required.");
        RuleFor(d => d.User.FirstName).NotNull().NotEmpty().WithMessage("FirstName is required.");
        RuleFor(d => d.User.LastName).NotNull().NotEmpty().WithMessage("LastName is required.");
        RuleFor(d => d.User.Email).NotNull().NotEmpty().WithMessage("Email is required.");
        RuleFor(d => d.User.Email).EmailAddress().WithMessage("Please specify a valid email address.");
        RuleFor(x => x.User.PhoneNumber)
            .NotEmpty().WithMessage("Phone Number is required.")
            .Matches(@"^\+?\d{10,15}$").WithMessage("Please specify a valid phone number.");
    }
}