using FluentValidation;

namespace HugHost.Application.Commands.Role.CreateRole;

public class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
{
    public CreateRoleCommandValidator()
    {
        RuleFor(d => d.Role.Name).NotNull().NotEmpty().WithMessage("RoleName is required.");
    }
}