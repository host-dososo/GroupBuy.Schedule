using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 會員到貨通知紀錄
/// </summary>
public partial class MemPickUpNoticeRecord
{
    public long Id { get; set; }

    /// <summary>
    /// 透過哪個設備通知 (from UserPushSubsInfo)
    /// </summary>
    public int? PushSubsId { get; set; }

    /// <summary>
    /// 透過哪個社群平台發送
    /// </summary>
    public int? SocTypeId { get; set; }

    public long OrderId { get; set; }

    public DateTime? SendTime { get; set; }

    public string? ErrorResult { get; set; }
}
