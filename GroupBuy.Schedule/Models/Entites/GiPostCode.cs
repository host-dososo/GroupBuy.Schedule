using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 郵遞區號
/// </summary>
public partial class GiPostCode
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 國家代碼(from Country)
    /// </summary>
    public string CountryCode { get; set; } = null!;

    /// <summary>
    /// 縣市名稱(from City)
    /// </summary>
    public string CityName { get; set; } = null!;

    /// <summary>
    /// 郵遞區號
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 鄉鎮區域名
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 道路
    /// </summary>
    public string Rode { get; set; } = null!;

    /// <summary>
    /// 投遞範圍
    /// </summary>
    public string Scope { get; set; } = null!;

    /// <summary>
    /// 備註
    /// </summary>
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
