using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class AggregatedCounter
{
    public string Key { get; set; } = null!;

    public long Value { get; set; }

    public DateTime? ExpireAt { get; set; }
}
