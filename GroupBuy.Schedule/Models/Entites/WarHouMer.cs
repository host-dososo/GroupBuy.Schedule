using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商家倉庫
/// </summary>
public partial class WarHouMer
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 商家序號
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 代碼
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 名稱
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int Sort { get; set; }

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
