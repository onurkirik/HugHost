using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs;
using MediatR;

namespace HugHost.Application.Queries.User.GetUser;

public record GetUserQuery(Guid Id) : IRequest<QueryResponse<UserDto>>;