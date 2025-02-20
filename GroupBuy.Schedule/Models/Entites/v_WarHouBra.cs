using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_WarHouBra
{
    public long Id { get; set; }

    public int MerchantId { get; set; }

    public int WarHouMerId { get; set; }

    public long GooSpecId { get; set; }

    public decimal Qty { get; set; }

    public decimal RetQty { get; set; }

    public decimal? NotRetQty { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public int Creator { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Updater { get; set; }

    public string WarHouMerStatus { get; set; } = null!;

    public long GoodsId { get; set; }

    public string GooSpecName { get; set; } = null!;

    public string GooName { get; set; } = null!;

    public string Num { get; set; } = null!;
}
