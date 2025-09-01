using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class Announcement
{
    public int Id { get; set; }

    /// <summary>
    /// 0:前台, 1:後台
    /// </summary>
    public byte? OwnSys { get; set; }

    /// <summary>
    /// 針對某個設備類型出現 0:PC, 1:Mobile
    /// </summary>
    public int? DeviceTypeId { get; set; }

    public string? ViewName { get; set; }

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
