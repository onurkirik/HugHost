namespace HugHost.Domain.Entities;

public class ActivityLog
{
    public Guid Id { get; set; }
    public Guid OwnerId { get; set; }
    public required string IPAdress { get; set; }
    public required string Details { get; set; }
}