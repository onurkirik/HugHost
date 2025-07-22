using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.User;
using Mediator.Net.Contracts;
using MediatR;

namespace HugHost.Application.Queries.User.GetUsers;

public class GetUsersQuery() : IRequest<QueryResponse<IEnumerable<UserDto>>>;