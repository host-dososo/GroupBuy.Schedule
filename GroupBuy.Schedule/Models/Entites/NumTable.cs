using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 取號表
/// </summary>
public partial class NumTable
{
    /// <summary>
    /// 表格名稱
    /// </summary>
    public string TabName { get; set; } = null!;

    /// <summary>
    /// 所屬商家序號
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 欄位名稱
    /// </summary>
    public string ColName { get; set; } = null!;

    /// <summary>
    /// 目前編號
    /// </summary>
    public int Number { get; set; }

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
