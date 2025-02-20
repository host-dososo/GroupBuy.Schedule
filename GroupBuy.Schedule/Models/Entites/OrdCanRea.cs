using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 訂單取消原因
/// </summary>
public partial class OrdCanRea
{
    /// <summary>
    /// 取消代碼
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 取消説明
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 創建時間
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 創建者
    /// </summary>
    public int Creator { get; set; }

    /// <summary>
    /// 編輯時間
    /// </summary>
    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// 編輯者編號
    /// </summary>
    public int? Updater { get; set; }
}
