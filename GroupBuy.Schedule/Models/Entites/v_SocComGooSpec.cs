using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_SocComGooSpec
{
    public long CommentId { get; set; }

    public long GooSpeId { get; set; }

    public long GroGooSpeId { get; set; }

    public decimal Qty { get; set; }

    public int MerchantId { get; set; }

    public string GooSpeName { get; set; } = null!;

    public string GooName { get; set; } = null!;

    public string Code { get; set; } = null!;

    public decimal PriceSell { get; set; }

    public decimal PriceBuy { get; set; }
}
