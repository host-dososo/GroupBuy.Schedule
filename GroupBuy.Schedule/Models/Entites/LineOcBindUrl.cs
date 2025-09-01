using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// LINE社群綁定連結 (不關聯MerSocChaId，避免重綁社群連結不同)
/// </summary>
public partial class LineOcBindUrl
{
    public int Id { get; set; }

    public int MerchantId { get; set; }

    /// <summary>
    /// 社群ID (from LineSelfbot)
    /// </summary>
    public string SquareMid { get; set; } = null!;

    /// <summary>
    /// 貼文ID (From LineSelfbot) /若是從後台發綁定文就會有資料
    /// </summary>
    public string? PostId { get; set; }

    /// <summary>
    /// 發布綁定文自動留言 - 留言ID
    /// </summary>
    public string? CommentId { get; set; }

    public string? Url { get; set; }

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
