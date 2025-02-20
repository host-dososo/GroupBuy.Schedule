using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 優惠條件
/// </summary>
public partial class PromoCond
{
    public int Id { get; set; }

    /// <summary>
    /// 關聯哪個優惠活動
    /// </summary>
    public int MerPromoId { get; set; }

    /// <summary>
    /// 執行對象ID
    /// </summary>
    public int ActTgtId { get; set; }

    /// <summary>
    /// 執行行為: 針對下單行為優惠 
    /// </summary>
    public int? PromoOrdActId { get; set; }

    /// <summary>
    /// 優惠期間內註冊
    /// </summary>
    public bool? IsRegAct { get; set; }

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
