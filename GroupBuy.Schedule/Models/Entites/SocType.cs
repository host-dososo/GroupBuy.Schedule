using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 社群類別
/// </summary>
public partial class SocType
{
    /// <summary>
    /// 社群類別：(1-&gt;FB社團, 2-&gt;FB粉專, 3-&gt;Line群組, 4-&gt;Line官方帳號), 5.IG
    /// </summary>
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    /// <summary>
    /// 父層 Id (子社群依賴於某個父社群) ex: &quot;Line群組&quot;依賴於&quot;Line&quot;
    /// </summary>
    public int? ParentId { get; set; }

    public bool CanPostFeed { get; set; }

    public string? Remark { get; set; }

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
