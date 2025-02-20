using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class MerPicPoiDelivLog
{
    public decimal Id { get; set; }

    public long MerPicPoiDelivId { get; set; }

    public long OrdItemDetailId { get; set; }

    /// <summary>
    /// 1: 配送, 2:到貨
    /// </summary>
    public byte Type { get; set; }

    public decimal Qty { get; set; }

    /// <summary>
    /// 創建日期時間
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 創建人員
    /// </summary>
    public int Creator { get; set; }
}
