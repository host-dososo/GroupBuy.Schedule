using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class MerSchedJob
{
    public int Id { get; set; }

    public int MerchantId { get; set; }

    /// <summary>
    /// 作業功能
    /// </summary>
    public int SysFunActId { get; set; }

    /// <summary>
    /// From HangFire.Job 
    /// </summary>
    public string? JobId { get; set; }

    /// <summary>
    /// From HangFire.Hash
    /// </summary>
    public string? HashKey { get; set; }

    public string? JobContent { get; set; }

    /// <summary>
    /// 執行結果
    /// </summary>
    public string? Result { get; set; }

    /// <summary>
    /// from HangFire.Job =&gt; ExpireAt
    /// </summary>
    public DateTime? ExpireAt { get; set; }

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
