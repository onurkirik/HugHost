using FluentValidation;

namespace HugHost.Application.Queries.Role.GetRole;

public class GetRoleQueryValidator : AbstractValidator<GetRoleQuery>
{
    public GetRoleQueryValidator()
    {
        RuleFor(d => d.Id).NotEmpty().WithMessage("Id is required.");
    }
}