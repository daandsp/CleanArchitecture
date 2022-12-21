namespace Domain.Entities;

public class DepartmentDiscord : BaseEntity
{
    public ulong GuildId { get; set; }
    public Department Department { get; set; }

    public DepartmentDiscordConfig Config { get; set; }

    public DepartmentDiscord() { }
}
