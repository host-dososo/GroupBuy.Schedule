using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class MemCart
{
    public int Id { get; set; }

    public int MemberId { get; set; }

    public int MerchantId { get; set; }

    public long? GooSpeId { get; set; }

    public long? GroGooSpeId { get; set; }

    public string OrdTypCode { get; set; } = null!;

    public decimal Qty { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
