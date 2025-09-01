using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_MemCart
{
    public int Id { get; set; }

    public int MemberId { get; set; }

    public int MerchantId { get; set; }

    public long GoodsId { get; set; }

    public long? GooSpeId { get; set; }

    public long? GroGooSpeId { get; set; }

    public string OrdTypCode { get; set; } = null!;

    public decimal Qty { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string RealName { get; set; } = null!;

    public string? FBName { get; set; }

    public string? LineName { get; set; }

    public string GooSpeName { get; set; } = null!;

    public string GooName { get; set; } = null!;

    public decimal? GooSpeBuyMaxCnt { get; set; }

    public decimal? GooBuyMaxCnt { get; set; }

    public decimal? GooQty { get; set; }
}
