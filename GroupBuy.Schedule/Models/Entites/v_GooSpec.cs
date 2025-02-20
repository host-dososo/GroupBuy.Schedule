using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_GooSpec
{
    public long GoodsId { get; set; }

    public int MerchantId { get; set; }

    public string GooNum { get; set; } = null!;

    public string GooName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal PriceBuy { get; set; }

    public decimal PriceSell { get; set; }

    public string? Description { get; set; }

    public long GooSpeId { get; set; }

    public string Code { get; set; } = null!;

    public decimal PriceBatch { get; set; }

    public decimal? BuyMaxCnt { get; set; }

    public bool IsSales { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public int Creator { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Updater { get; set; }
}
