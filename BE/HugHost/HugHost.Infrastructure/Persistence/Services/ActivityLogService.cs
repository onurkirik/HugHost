using HugHost.Application.Common.Interfaces.Repositories;
using HugHost.Application.Common.Interfaces.Services;
using HugHost.Domain.Entities;

namespace HugHost.Infrastructure.Persistence.Services;

public class ActivityLogService : IActivityLogService
{
    private readonly IGenericRepository<ActivityLog> _activityLogRepository;

    public ActivityLogService(IGenericRepository<ActivityLog> activityLogService)
    {
        _activityLogRepository = activityLogService;
    }
    
    public Task AddLogAsync(Guid ownerId, string ipAdress, object details)
    {
        return null;
    }
}