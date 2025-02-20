using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_PromoRewMethod
{
    public int Id { get; set; }

    public int MerPromoId { get; set; }

    public byte Type { get; set; }

    public byte? CouType { get; set; }

    public bool? AutoAdjWar { get; set; }

    public string? Name { get; set; }

    public string? CheckCode { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public int Creator { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Updater { get; set; }

    public string? TypeName { get; set; }

    public string? CouTypName { get; set; }
}
