using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_LineOcMember
{
    public int MerchantId { get; set; }

    public int? MemberId { get; set; }

    public string Pid { get; set; } = null!;

    public string? Nickname { get; set; }

    public string? ImageObsHash { get; set; }

    public string? Role { get; set; }

    public string? State { get; set; }

    public int? BindUrlId { get; set; }

    public string RealName { get; set; } = null!;

    public string? LineUsrId { get; set; }

    public string? LineName { get; set; }

    public string? HeadImgUrl { get; set; }

    public string Status { get; set; } = null!;

    public string? BindPostId { get; set; }

    public string? BindCommentId { get; set; }

    public string? Url { get; set; }

    public DateTime CreatedTime { get; set; }

    public int Creator { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Updater { get; set; }
}
