using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_GroComment
{
    public long Id { get; set; }

    public long MerSocChaId { get; set; }

    public string RootFeedId { get; set; } = null!;

    public string? OriFeedId { get; set; }

    public string CommentId { get; set; } = null!;

    public int? MerSchedJobId { get; set; }

    public int MemId { get; set; }

    public string MemName { get; set; } = null!;

    public string MemSocId { get; set; } = null!;

    public string MemSocName { get; set; } = null!;

    public string? MemSocHeadImgUrl { get; set; }

    public string MemSocBindState { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public DateTime? ComTime { get; set; }

    public bool IsFather { get; set; }

    public long? OrdId { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string Status { get; set; } = null!;

    public string MerSocChaName { get; set; } = null!;

    public int SocTypeId { get; set; }

    public bool MerSocChaBind { get; set; }

    public long GroupId { get; set; }

    public int MerchantId { get; set; }

    public string SocChaId { get; set; } = null!;

    public string? SocFeedId { get; set; }

    public bool CommentAsOrder { get; set; }
}
