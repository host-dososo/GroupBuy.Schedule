using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_Goods
{
    public long Id { get; set; }

    public int MerchantId { get; set; }

    public string Num { get; set; } = null!;

    public int GooCat2Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal PriceBuy { get; set; }

    public decimal PriceSell { get; set; }

    public decimal? LastPrice { get; set; }

    public decimal? BuyMaxCnt { get; set; }

    public string? Description { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public bool DisOrder { get; set; }

    public string? DisOrderRsn { get; set; }

    public int? DisOrdSocVarKey { get; set; }

    public bool PreOrder { get; set; }

    public bool IsTop { get; set; }

    public long? SupGooId { get; set; }

    public string? Remark { get; set; }

    public int Sort { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public int Creator { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Updater { get; set; }

    public int? SalesStatus { get; set; }

    public string? SalesStatusText { get; set; }
}
