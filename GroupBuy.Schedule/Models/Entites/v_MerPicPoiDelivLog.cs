using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_MerPicPoiDelivLog
{
    public long MerPicPoiDelivId { get; set; }

    public long OrdItemDetailId { get; set; }

    public byte Type { get; set; }

    public decimal DelivQty { get; set; }

    public int Creator { get; set; }

    public DateTime CreatedTime { get; set; }

    public string OrdNum { get; set; } = null!;

    public int MerchantId { get; set; }

    public int MemberId { get; set; }

    public string? MemReaName { get; set; }

    public string DelivMan { get; set; } = null!;

    public string? DelivManMobile { get; set; }

    public string DelivNum { get; set; } = null!;

    public byte DelivType { get; set; }

    public int MerPicPoiId { get; set; }

    public decimal? RetQty { get; set; }
}
