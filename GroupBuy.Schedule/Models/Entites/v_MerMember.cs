using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_MerMember
{
    public int MerchantId { get; set; }

    public int MemberId { get; set; }

    public int Number { get; set; }

    public string Status { get; set; } = null!;

    public string? LasLogIP { get; set; }

    public DateTime? LasLogTime { get; set; }

    public int LogCount { get; set; }

    public int AccFaiCount { get; set; }

    public string? Address { get; set; }

    public string? GiPosName { get; set; }

    public string? GiPosCode { get; set; }

    public string? GiCitCode { get; set; }

    public string Name { get; set; } = null!;

    public string RealName { get; set; } = null!;

    public string? IdNumber { get; set; }

    public string? Gender { get; set; }

    public DateOnly? Birthday { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? MobileLastThree { get; set; }

    public string? Receiver { get; set; }

    public string? FBUsrId { get; set; }

    public string? FBName { get; set; }

    public bool? FBAuthorize { get; set; }

    public string? FBRecipientLoginId { get; set; }

    public string? FBLongLivedToken { get; set; }

    public string? FBPSID { get; set; }

    public string? LineUsrId { get; set; }

    public string? LineName { get; set; }

    public string? LineToken { get; set; }

    public string? LineNotifyToken { get; set; }

    public string? LineStaMessage { get; set; }

    public string? HeadImgUrl { get; set; }

    public string? GiCouCode { get; set; }

    public string MemTypCode { get; set; } = null!;

    public int MerShiWayId { get; set; }

    public int MerPayTypId { get; set; }

    public int? MerPicPoiId { get; set; }

    public decimal? ShopAmt { get; set; }

    public int? RefMemberId { get; set; }

    public int? RefMerchantId { get; set; }

    public string MerMemStatus { get; set; } = null!;

    public DateOnly? LastDealDate { get; set; }

    public DateTime CreatedTime { get; set; }
}
