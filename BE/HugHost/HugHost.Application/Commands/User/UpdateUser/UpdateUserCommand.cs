using HugHost.Application.Common.Responses;
using HugHost.Application.Shared.DTOs.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HugHost.Application.Commands.User.UpdateUser;

public record UpdateUserCommand([FromBody] UpdateUserDto User) : IRequest<CommandResponse<UserDto>>;