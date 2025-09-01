using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// Line社群會員綁定Mapping
/// </summary>
public partial class LineOcMemPid
{
    public long Id { get; set; }

    /// <summary>
    /// 社群會員ID (From LineSelfbot)
    /// </summary>
    public string Pid { get; set; } = null!;

    public int? MemberId { get; set; }

    /// <summary>
    /// 社群會員匿名名稱 (From LineSelfbot)
    /// </summary>
    public string? Nickname { get; set; }

    /// <summary>
    /// 社群會員頭貼 (From LineSelfbot)
    /// </summary>
    public string? ImageObsHash { get; set; }

    /// <summary>
    /// 社群會員身分 (From LineSelfbot)
    /// </summary>
    public string? Role { get; set; }

    /// <summary>
    /// 社群會員狀態 (From LineSelfbot)
    /// </summary>
    public string? State { get; set; }

    public int? BindUrlId { get; set; }

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
