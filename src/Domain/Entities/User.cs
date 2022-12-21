namespace Domain.Entities;

public class User : BaseEntity
{
    public ulong DiscordId { get; set; }
    public ulong RobloxId { get; set; }

    public List<LogEntry> LogEntries { get; set; } = new();
}
