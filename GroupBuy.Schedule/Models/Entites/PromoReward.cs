using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 優惠回饋
/// </summary>
public partial class PromoReward
{
    public int Id { get; set; }

    /// <summary>
    /// 關聯哪個優惠活動
    /// </summary>
    public int MerPromoId { get; set; }

    /// <summary>
    /// 優惠對象
    /// </summary>
    public int PromoTgtId { get; set; }

    /// <summary>
    /// 回饋種類(1:折扣整筆訂單/2:贈送購物金/3:贈送商品)
    /// </summary>
    public int TypeId { get; set; }

    /// <summary>
    /// 回饋單位 (元/%/件)
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// 回饋值
    /// </summary>
    public decimal Value { get; set; }

    /// <summary>
    /// 贈送何種商品
    /// </summary>
    public long? GooSpeId { get; set; }

    /// <summary>
    /// 回饋上限 (固定單位:元)
    /// </summary>
    public decimal? Limit { get; set; }

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
