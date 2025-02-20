using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 叫貨單明細
/// </summary>
public partial class PurOrdDetail
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 採購(叫貨)單序號
    /// </summary>
    public long PurOrdId { get; set; }

    /// <summary>
    /// 商品規格序號
    /// </summary>
    public long GooSpecId { get; set; }

    /// <summary>
    /// 成本
    /// </summary>
    public decimal Cost { get; set; }

    /// <summary>
    /// 採購(叫貨)數量
    /// </summary>
    public decimal PurQty { get; set; }

    /// <summary>
    /// 到貨數量
    /// </summary>
    public decimal ArrQty { get; set; }

    /// <summary>
    /// 採購(叫貨)金額
    /// </summary>
    public decimal PurAmt { get; set; }

    /// <summary>
    /// 有效日期
    /// </summary>
    public DateTime? ExpDate { get; set; }
}
