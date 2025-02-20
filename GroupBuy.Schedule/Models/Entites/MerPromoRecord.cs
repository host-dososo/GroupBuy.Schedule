using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 優惠紀錄
/// </summary>
public partial class MerPromoRecord
{
    /// <summary>
    /// 誰被優惠
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 執行對象
    /// </summary>
    public int ActMemberId { get; set; }

    /// <summary>
    /// 紀錄主體表對應ID Ex:dbo.Order =&gt; OrderId, dbo.GooSpec =&gt; GooSpecId ...
    /// </summary>
    public long? TabRefId { get; set; }

    /// <summary>
    /// 紀錄主體表ID，關聯 SysTab 表
    /// </summary>
    public int? SysTabId { get; set; }

    /// <summary>
    /// 適用優惠回饋
    /// </summary>
    public int PromoRewardId { get; set; }

    /// <summary>
    /// 回饋多少元
    /// </summary>
    public decimal RewardValue { get; set; }

    public string? RewardUnit { get; set; }

    /// <summary>
    /// 使用時間/創建時間
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 創建人/觸發優惠回饋者
    /// </summary>
    public int Creator { get; set; }

    /// <summary>
    /// 0: 前台/1:後台
    /// </summary>
    public byte CreatorType { get; set; }
}
