using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 回饋方式
/// </summary>
public partial class PromoRewMethod
{
    public int Id { get; set; }

    public int MerPromoId { get; set; }

    /// <summary>
    /// 回饋類型 (1:後台手動執行回饋/2:設置前台活動專區優惠券)
    /// </summary>
    public byte Type { get; set; }

    /// <summary>
    /// 優惠券分類 (0:現場兌換區/1:線上優惠券)
    /// </summary>
    public byte? CouType { get; set; }

    public string? Name { get; set; }

    public string? CheckCode { get; set; }

    /// <summary>
    /// 是否自動調整庫存
    /// </summary>
    public bool? AutoAdjWar { get; set; }

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
