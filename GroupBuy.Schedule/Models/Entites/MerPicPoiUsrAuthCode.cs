using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 成為取貨點使用者邀請代碼
/// </summary>
public partial class MerPicPoiUsrAuthCode
{
    public int Id { get; set; }

    /// <summary>
    /// 取貨點使用者 Num (From NumTable)
    /// </summary>
    public int MerPicPoiUsrNum { get; set; }

    /// <summary>
    /// 取貨點ID
    /// </summary>
    public int MerPicPoiId { get; set; }

    /// <summary>
    /// 雜湊亂數
    /// </summary>
    public string HashCode { get; set; } = null!;

    /// <summary>
    /// 申請完成時間
    /// </summary>
    public DateTime? AppliedTime { get; set; }

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
