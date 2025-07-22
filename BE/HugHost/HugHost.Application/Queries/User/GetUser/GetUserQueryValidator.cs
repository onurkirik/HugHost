using FluentValidation;

namespace HugHost.Application.Queries.User.GetUser;

public class GetUserQueryValidator : AbstractValidator<GetUserQuery>
{
    public GetUserQueryValidator()
    {
        RuleFor(d => d.Id).NotEmpty().WithMessage("Id is required")
            .Must(id => Guid.TryParse(id.ToString(), out _)).WithMessage("Id parameter must have a valid GUID");
    }
}