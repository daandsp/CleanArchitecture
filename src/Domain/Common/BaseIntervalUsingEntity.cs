using Domain.Utilities;

namespace Domain.Common;

public class BaseIntervalUsingEntity : BaseEntity
{
    public ulong IntervalStart { get; set; } = 0;
    public ulong? IntervalEnd { get; set; }


    public BaseIntervalUsingEntity(ulong intervalStart)
    {
        IntervalStart = intervalStart;
    }

    public BaseIntervalUsingEntity(ulong intervalStart, ulong intervalEnd)
    {
        IntervalStart = intervalStart;
        IntervalEnd = intervalEnd;
    }

    public BaseIntervalUsingEntity(TimeSpan timeSpan)
    {
        IntervalEnd = Convert.ToUInt64(timeSpan.TotalMilliseconds);
    }

    public TimeSpan GetIntervalDuration()
    {
        return TimeSpan.FromMilliseconds(IntervalEnd ?? TimeHelper.GetEpochms() - IntervalStart);
    }
}
