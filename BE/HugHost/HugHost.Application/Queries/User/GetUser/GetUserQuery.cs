using MediatR;

namespace HugHost.Application.Queries.User.GetUser;

public record GetUserQuery(Guid Id) : IRequest<GetUserQueryResponse>;