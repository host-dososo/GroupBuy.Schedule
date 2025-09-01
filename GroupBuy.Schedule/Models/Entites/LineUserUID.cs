using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class LineUserUID
{
    public long Id { get; set; }

    /// <summary>
    /// 0: 會員/ 1:商家
    /// </summary>
    public byte OwnSys { get; set; }

    /// <summary>
    /// 商家or會員ID
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// LINE名稱 (From LineSelfbot)
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// LINE UID (From LineSelfbot)
    /// </summary>
    public string UID { get; set; } = null!;

    public string? State { get; set; }

    /// <summary>
    /// LINE 頭貼 (From LineSelfbot)
    /// </summary>
    public string? ImageObsHash { get; set; }

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
