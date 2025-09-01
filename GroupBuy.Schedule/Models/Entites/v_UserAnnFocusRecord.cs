using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_UserAnnFocusRecord
{
    public int Id { get; set; }

    public byte? OwnSys { get; set; }

    public int? UserId { get; set; }

    public DateTime? LastFocusTime { get; set; }

    public string? ViewName { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public int Creator { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Updater { get; set; }

    public string? RealName { get; set; }

    public int? DeviceTypeId { get; set; }
}
