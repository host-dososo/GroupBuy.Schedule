using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 團組商品規格
/// </summary>
public partial class GroGooSpec
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 團組商品序號(from GroGoods)
    /// </summary>
    public long GroGooId { get; set; }

    /// <summary>
    /// 商品規格序號(from GooSpec)
    /// </summary>
    public long GooSpeId { get; set; }

    /// <summary>
    /// 訂購代碼(給社群留言成立訂單使用的代碼)
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 進價
    /// </summary>
    public decimal PriceBuy { get; set; }

    /// <summary>
    /// 單價
    /// </summary>
    public decimal PriceUnit { get; set; }

    /// <summary>
    /// 售價
    /// </summary>
    public decimal PriceSell { get; set; }

    /// <summary>
    /// 數量
    /// </summary>
    public decimal Qty { get; set; }

    /// <summary>
    /// 啟用碼(0-&gt;不啟用,1-&gt;啟用)
    /// </summary>
    public string IsUsed { get; set; } = null!;

    /// <summary>
    /// 狀態(0-&gt;停用,1-&gt;使用中,9-&gt;刪除)
    /// </summary>
    public string Status { get; set; } = null!;
}
