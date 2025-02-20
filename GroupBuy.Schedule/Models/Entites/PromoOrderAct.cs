using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 優惠下單行為
/// </summary>
public partial class PromoOrderAct
{
    public int Id { get; set; }

    /// <summary>
    /// 操作位置 (null:任意處/1:前台/2:現場/3:FB留言)
    /// </summary>
    public byte? ActLoc { get; set; }

    /// <summary>
    /// 多少值
    /// </summary>
    public decimal Value { get; set; }

    /// <summary>
    /// 1: 滿多少
    /// </summary>
    public byte ValueType { get; set; }

    /// <summary>
    /// 滿多少元/滿多少件 (元/件)
    /// </summary>
    public string Unit { get; set; } = null!;

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
