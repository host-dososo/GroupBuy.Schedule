using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商品規格
/// </summary>
public partial class GooSpec
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 商品序號(from Goods)
    /// </summary>
    public long GoodsId { get; set; }

    /// <summary>
    /// 規格代碼(給社群留言成立訂單使用的代碼)
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 規格值
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 規格說明
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 進價
    /// </summary>
    public decimal PriceBuy { get; set; }

    /// <summary>
    /// 售價
    /// </summary>
    public decimal PriceSell { get; set; }

    /// <summary>
    /// 批客價
    /// </summary>
    public decimal PriceBatch { get; set; }

    /// <summary>
    /// 一個會員最多只能買多少個
    /// </summary>
    public decimal? BuyMaxCnt { get; set; }

    /// <summary>
    /// 商品規格是否銷售(0-&gt;否/1-&gt;是)
    /// </summary>
    public bool IsSales { get; set; }

    /// <summary>
    /// 狀態(0-&gt;停用,1-&gt;使用中,9-&gt;刪除)
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// 創建日期時間
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 創建人員
    /// </summary>
    public int Creator { get; set; }

    /// <summary>
    /// 更新日期時間
    /// </summary>
    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// 更新人員
    /// </summary>
    public int? Updater { get; set; }
}
