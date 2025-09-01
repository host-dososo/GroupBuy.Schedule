using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class UserPushSubsInfo
{
    public int Id { get; set; }

    /// <summary>
    /// 使用者ID 須根據 UserType
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// 使用者類型 (0:會員/1:商家使用者)
    /// </summary>
    public byte? UserType { get; set; }

    /// <summary>
    /// 設備類型 0:PC, 1:Mobile
    /// </summary>
    public byte? DeviceType { get; set; }

    public string? DeviceDesc { get; set; }

    public string? Endpoint { get; set; }

    public string? P256DH { get; set; }

    public string? Auth { get; set; }

    public DateTime CreateTime { get; set; }
}
