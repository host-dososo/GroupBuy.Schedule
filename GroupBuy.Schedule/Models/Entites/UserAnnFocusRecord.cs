using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 使用者公告點擊紀錄
/// </summary>
public partial class UserAnnFocusRecord
{
    public int AnnId { get; set; }

    public int UserId { get; set; }

    /// <summary>
    /// 最後確認公告日期
    /// </summary>
    public DateTime? LastFocusTime { get; set; }
}
