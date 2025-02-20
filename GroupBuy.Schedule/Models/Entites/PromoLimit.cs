using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 優惠限制
/// </summary>
public partial class PromoLimit
{
    public int Id { get; set; }

    /// <summary>
    /// 關聯哪個優惠活動
    /// </summary>
    public int MerPromoId { get; set; }

    /// <summary>
    /// 限制種類 (1:每人最多優惠/2:執行對象最多執行)
    /// </summary>
    public byte TypeId { get; set; }

    /// <summary>
    /// 限制值
    /// </summary>
    public decimal Value { get; set; }

    public string? Unit { get; set; }

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
