namespace Domain.Entities;

public class DepartmentDiscordConfig : BaseEntity
{
    public int DepartmentDiscordId { get; set; }
    public bool AutomaticLogsEnabled { get; set; } = false;
    public ulong? BotLogsChannelId { get; set; }
    public string? BotModeratorRoleName { get; set; } = "LoggingBot Access";

    public DepartmentDiscord DepartmentDiscord { get; set; }

    public DepartmentDiscordConfig() { }

    public DepartmentDiscordConfig(int departmentDiscordId, ulong botLogsChannelId, 
        bool automaticLogsEnabled, string botModeratorRoleName)
    {
        DepartmentDiscordId = departmentDiscordId;
        BotLogsChannelId = botLogsChannelId;
        AutomaticLogsEnabled = automaticLogsEnabled;
        BotModeratorRoleName = botModeratorRoleName;
    }
}
