using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_MemPickUpNoticeRecord
{
    public long Id { get; set; }

    public string OrdNum { get; set; } = null!;

    public int MerchantId { get; set; }

    public int MemberId { get; set; }

    public string? HeadImgUrl { get; set; }

    public int? PushSubsId { get; set; }

    public int? SocTypeId { get; set; }

    public string RealName { get; set; } = null!;

    public string? FBName { get; set; }

    public string? LineName { get; set; }

    public string? LineUsrId { get; set; }

    public string? FBUsrId { get; set; }

    public long OrderId { get; set; }

    public long? PicUpId { get; set; }

    public long? ShipId { get; set; }

    public string? ShipFormNum { get; set; }

    public DateTime? SendTime { get; set; }

    public string? ErrorResult { get; set; }

    public DateTime? ArrivalTime { get; set; }

    public byte? DeviceType { get; set; }

    public string? DeviceDesc { get; set; }
}
