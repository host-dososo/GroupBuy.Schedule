using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商家設定檔
/// </summary>
public partial class MerVariable
{
    public long Id { get; set; }

    /// <summary>
    /// 商家ID
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 設定檔識別
    /// </summary>
    public int KeyId { get; set; }

    /// <summary>
    /// 設定值
    /// </summary>
    public string? Value { get; set; }

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
