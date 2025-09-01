using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// IOS 到貨通知 PWA APP 登入狀態
/// </summary>
public partial class NoticeAppIdState
{
    /// <summary>
    /// 序號
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// 會員序號
    /// </summary>
    public int? MemberId { get; set; }

    /// <summary>
    /// 最後登入時間
    /// </summary>
    public DateTime? LastLoginTime { get; set; }

    /// <summary>
    /// 登入到期日
    /// </summary>
    public DateTime? ExpTime { get; set; }

    public int ViewTimes { get; set; }

    /// <summary>
    /// 設備類型 0:PC, 1:Mobile
    /// </summary>
    public byte? DeviceType { get; set; }

    public string? DeviceDesc { get; set; }

    public string? Ip { get; set; }
}
