namespace Domain.Entities;

public class LogEntry : BaseIntervalUsingEntity
{
    public int DepartmentDiscordId { get; set; }
    public int UserId { get; set; }
    public DateTime DateCreated { get; } = DateTime.Now;

    public DepartmentDiscord DepartmentDiscord { get; set; }
    public User User { get; set; }


    public LogEntry(int departmentDiscordId, int userId, ulong intervalStart)
        :base(intervalStart)
    {
        SetProperties(departmentDiscordId, userId);
    }

    public LogEntry(int departmentDiscordId, int userId, ulong intervalStart, ulong intervalEnd)
        : base(intervalStart, intervalEnd)
    {
        SetProperties(departmentDiscordId, userId);
    }

    public LogEntry(int departmentDiscordId, int userId, TimeSpan timeSpan)
        : base(timeSpan)
    {
        SetProperties(departmentDiscordId, userId);
    }

    private void SetProperties(int departmentDiscordId, int userId)
    {
        DepartmentDiscordId = departmentDiscordId;
        UserId = userId;
    }
}
