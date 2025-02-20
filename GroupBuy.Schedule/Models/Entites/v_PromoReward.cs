using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_PromoReward
{
    public int Id { get; set; }

    public int MerPromoId { get; set; }

    public int PromoTgtId { get; set; }

    public int TypeId { get; set; }

    public string? Unit { get; set; }

    public decimal Value { get; set; }

    public decimal? Limit { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public int Creator { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Updater { get; set; }

    public string? TypeName { get; set; }

    public string PromoTgtName { get; set; } = null!;

    public long? GooSpeId { get; set; }

    public string? GooSpeName { get; set; }

    public string? GooName { get; set; }
}
