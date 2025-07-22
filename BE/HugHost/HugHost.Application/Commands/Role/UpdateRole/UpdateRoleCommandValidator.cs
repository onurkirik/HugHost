using FluentValidation;
using HugHost.Application.Commands.Role.CreateRole;

namespace HugHost.Application.Commands.Role.UpdateRole;

public class UpdateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
{
    public UpdateRoleCommandValidator()
    {
        RuleFor(d => d.Role.Name).NotNull().NotEmpty().WithMessage("RoleName is required.");
    }
}