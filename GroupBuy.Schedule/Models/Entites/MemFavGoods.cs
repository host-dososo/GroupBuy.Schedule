using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 會員最愛好物商品
/// </summary>
public partial class MemFavGoods
{
    /// <summary>
    /// 會員序號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 商品序號
    /// </summary>
    public long GoodsId { get; set; }
}
