using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商家優惠活動
/// </summary>
public partial class MerPromo
{
    public int Id { get; set; }

    public int MerchantId { get; set; }

    /// <summary>
    /// 優惠名稱
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 優惠說明
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 優惠期間: 開始時間
    /// </summary>
    public DateTime StartTime { get; set; }

    /// <summary>
    /// 優惠期間: 結束時間
    /// </summary>
    public DateTime EndTime { get; set; }

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
