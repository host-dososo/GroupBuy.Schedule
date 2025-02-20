using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 取貨點配送
/// </summary>
public partial class MerPicPoiDeliv
{
    public long Id { get; set; }

    public string Number { get; set; } = null!;

    public string DelivMan { get; set; } = null!;

    public string? DelivManMobile { get; set; }

    /// <summary>
    /// 配送方式 1:親自運送
    /// </summary>
    public byte DelivType { get; set; }

    public int MerPicPoiId { get; set; }

    public DateTime? DeliverTime { get; set; }

    public DateTime? ArrivedTime { get; set; }

    public string? Remark { get; set; }

    /// <summary>
    /// 狀態(0-&gt;停用,1-&gt;使用中,9-&gt;刪除)
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
