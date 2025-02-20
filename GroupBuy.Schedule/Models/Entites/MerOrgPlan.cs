using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class MerOrgPlan
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 客戶所屬組織序號
    /// </summary>
    public int? MerOrgId { get; set; }

    /// <summary>
    /// 編號(購買次數)
    /// </summary>
    public int? Num { get; set; }

    /// <summary>
    /// 商家方案代碼
    /// </summary>
    public string? MerPlanCode { get; set; }

    /// <summary>
    /// 方案可使用數上限
    /// </summary>
    public short? LimitCnt { get; set; }

    /// <summary>
    /// 方案剩餘可使用數
    /// </summary>
    public short? RemainCnt { get; set; }

    /// <summary>
    /// 開始日期
    /// </summary>
    public DateTime? StartingDate { get; set; }

    /// <summary>
    /// 結束日期
    /// </summary>
    public DateTime? ExpiryDate { get; set; }

    /// <summary>
    /// 狀態(0-&gt;關閉,1-&gt;開啟,9-&gt;刪除)
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
