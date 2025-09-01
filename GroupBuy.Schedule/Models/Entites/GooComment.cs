using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商品社群留言
/// </summary>
public partial class GooComment
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 賣場商品頻道 ID
    /// </summary>
    public long MerSocChaId { get; set; }

    /// <summary>
    /// 最上層商品發文Id
    /// </summary>
    public string RootFeedId { get; set; } = null!;

    /// <summary>
    /// 原始貼文ID (若留言在圖片貼文才有資料，此為圖片貼文的源頭貼文ID)
    /// </summary>
    public string? OriFeedId { get; set; }

    /// <summary>
    /// 留言Comment ID
    /// </summary>
    public string CommentId { get; set; } = null!;

    /// <summary>
    /// 執行紀錄ID
    /// </summary>
    public int? MerSchedJobId { get; set; }

    /// <summary>
    /// 會員Member ID
    /// </summary>
    public int MemId { get; set; }

    /// <summary>
    /// 會員Member Name
    /// </summary>
    public string MemName { get; set; } = null!;

    /// <summary>
    /// 會員社群ID
    /// </summary>
    public string MemSocId { get; set; } = null!;

    /// <summary>
    /// 會員社群名稱
    /// </summary>
    public string MemSocName { get; set; } = null!;

    public string? MemSocHeadImgUrl { get; set; }

    /// <summary>
    /// 社群會員綁定狀態 (0: 未綁定時下單/1:已綁定時下單 /2:綁定前下單)
    /// </summary>
    public string? MemSocBindState { get; set; }

    /// <summary>
    /// 留言內容
    /// </summary>
    public string Comment { get; set; } = null!;

    /// <summary>
    /// 留言時間
    /// </summary>
    public DateTime? ComTime { get; set; }

    public bool IsFather { get; set; }

    /// <summary>
    /// 對應的訂單編號
    /// </summary>
    public long? OrdId { get; set; }

    public DateTime? DeletedTime { get; set; }

    /// <summary>
    /// 狀態：(0-&gt;未處理留言, 1-&gt;已成立訂單留言, 2-&gt;毋須成立訂單留言, 9-&gt;已刪除留言)
    /// </summary>
    public string Status { get; set; } = null!;
}
