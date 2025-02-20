using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_PromoLimit
{
    public int Id { get; set; }

    public int MerPromoId { get; set; }

    public byte TypeId { get; set; }

    public string? TypeName { get; set; }

    public decimal Value { get; set; }

    public string? Unit { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public int Creator { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Updater { get; set; }
}
