using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商品和供應商家關聯表
/// </summary>
public partial class GooMerSup
{
    /// <summary>
    /// 商品序號
    /// </summary>
    public long GoodsId { get; set; }

    /// <summary>
    /// 供應商序號
    /// </summary>
    public int MerSupId { get; set; }
}
