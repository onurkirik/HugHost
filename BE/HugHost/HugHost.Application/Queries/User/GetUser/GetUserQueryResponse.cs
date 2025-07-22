using HugHost.Domain.Entities;

namespace HugHost.Application.Queries.User.GetUser;

public class GetUserQueryResponse
{
    public Domain.Entities.User? Result { get; set; }
}