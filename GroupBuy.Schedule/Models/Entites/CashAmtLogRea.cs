using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 購物金原因表
/// </summary>
public partial class CashAmtLogRea
{
    /// <summary>
    /// 原因代碼
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 説明
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 創建時間
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 創建者編號
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
