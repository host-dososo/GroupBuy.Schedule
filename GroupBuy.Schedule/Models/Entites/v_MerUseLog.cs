using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_MerUseLog
{
    public int MerchantId { get; set; }

    public string Name { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string Month { get; set; } = null!;

    public string Week { get; set; } = null!;

    public int? Times { get; set; }

    public decimal? StayHours { get; set; }
}
