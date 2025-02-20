using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 團購社群頻道
/// </summary>
public partial class GroSocChannel
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 團組序號
    /// </summary>
    public long GroupId { get; set; }

    /// <summary>
    /// 社群類別(Form SocType)
    /// </summary>
    public int SocTypeId { get; set; }

    /// <summary>
    /// 商家社群頻道序號
    /// </summary>
    public int MerSocChaId { get; set; }

    /// <summary>
    /// 商家社群頻道發文序號
    /// </summary>
    public string? SocFeedId { get; set; }

    /// <summary>
    /// 記錄FB 的 feed object id 對應的 post id (兩者都可抓取發文資料)
    /// </summary>
    public string? SocPostId { get; set; }

    /// <summary>
    /// 允許社群留言成立訂單
    /// </summary>
    public bool CommentAsOrder { get; set; }

    /// <summary>
    /// 發佈時間
    /// </summary>
    public DateTime? PubTime { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// 創建日期時間
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 創建人員
    /// </summary>
    public int Creator { get; set; }

    /// <summary>
    /// 更新日期時間
    /// </summary>
    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// 更新人員
    /// </summary>
    public int? Updater { get; set; }
}
