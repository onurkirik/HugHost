namespace HugHost.Application.Common.Interfaces.Services;

public interface IActivityLogService
{
    Task AddLogAsync(Guid ownerId, string ipAdress, object details);
}