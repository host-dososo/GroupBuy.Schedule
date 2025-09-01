using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_NoticeAppIdState
{
    public Guid Id { get; set; }

    public int? MemberId { get; set; }

    public DateTime? LastLoginTime { get; set; }

    public DateTime? ExpTime { get; set; }

    public bool? CanLogin { get; set; }

    public string RealName { get; set; } = null!;

    public string? FBName { get; set; }

    public string? LineUsrId { get; set; }

    public string? FBUsrId { get; set; }

    public string? LineName { get; set; }

    public int ViewTimes { get; set; }

    public byte? DeviceType { get; set; }

    public string? DeviceDesc { get; set; }

    public string? Ip { get; set; }
}
