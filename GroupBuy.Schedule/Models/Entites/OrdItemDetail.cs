using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 訂單項目明細
/// </summary>
public partial class OrdItemDetail
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 訂單項目序號(from OrdItem)
    /// </summary>
    public long OrdItemId { get; set; }

    /// <summary>
    /// 商品規格序號(from GooSpec)
    /// </summary>
    public long GooSpeId { get; set; }

    /// <summary>
    /// 商品規格名稱(from GooSpec)
    /// </summary>
    public string GooSpeName { get; set; } = null!;

    /// <summary>
    /// 商品規格描述(from GooSpec)
    /// </summary>
    public string? GooSpeDescript { get; set; }

    /// <summary>
    /// 商品規格售價(from GooSpec)
    /// </summary>
    public decimal GooSpePriceSell { get; set; }

    /// <summary>
    /// 團組商品規格售價
    /// </summary>
    public decimal? GroGooSpePriceSell { get; set; }

    /// <summary>
    /// 團組商品規格序號
    /// </summary>
    public long? GroGooSpeId { get; set; }

    /// <summary>
    /// 購買數量
    /// </summary>
    public decimal Qty { get; set; }

    /// <summary>
    /// 配貨數量
    /// </summary>
    public decimal? RetQty { get; set; }

    /// <summary>
    /// 小計金額
    /// </summary>
    public decimal SubTolAmt { get; set; }

    /// <summary>
    /// 會員取貨時間
    /// </summary>
    public DateTime? MemPickUpTime { get; set; }
}
