using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_MerVariable
{
    public long Id { get; set; }

    public int MerchantId { get; set; }

    public int KeyId { get; set; }

    public int Num { get; set; }

    public string OwnSys { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? DefValue { get; set; }

    public string? Description { get; set; }

    public string? Value { get; set; }

    public string? Code { get; set; }

    public string? Unit { get; set; }
}
