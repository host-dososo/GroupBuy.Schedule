using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_PromoOrderAct
{
    public int Id { get; set; }

    public byte? ActLoc { get; set; }

    public string? ActLocName { get; set; }

    public decimal Value { get; set; }

    public byte ValueType { get; set; }

    public string? ValueTypeName { get; set; }

    public string Unit { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public int Creator { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Updater { get; set; }
}
