using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 折讓原因説明
/// </summary>
public partial class DebitAmtRea
{
    /// <summary>
    /// 代碼
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 原因説明
    /// </summary>
    public string Description { get; set; } = null!;

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
    /// 編輯者
    /// </summary>
    public int? Updater { get; set; }
}
