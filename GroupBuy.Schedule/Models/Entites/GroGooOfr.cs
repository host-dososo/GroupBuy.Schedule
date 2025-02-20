using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 團組商品折扣
/// </summary>
public partial class GroGooOfr
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
    /// 適用會員類型(1:一般會員/2:批客/3:門市顧客 from MemType)
    /// </summary>
    public string MemTypeCode { get; set; } = null!;

    /// <summary>
    /// 起訂數量
    /// </summary>
    public decimal Qty { get; set; }

    /// <summary>
    /// 優惠選項代碼(1-&gt;每件減固定金額, 2-&gt;整單折扣)
    /// </summary>
    public string OptionCode { get; set; } = null!;

    /// <summary>
    /// 減少金額
    /// </summary>
    public decimal? DiscountAmt { get; set; }

    /// <summary>
    /// 減收折扣
    /// </summary>
    public decimal? DiscountPct { get; set; }

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
