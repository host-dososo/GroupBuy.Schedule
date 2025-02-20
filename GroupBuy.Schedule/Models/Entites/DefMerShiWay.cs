using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 預設商家運送/取貨方式
/// </summary>
public partial class DefMerShiWay
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 編號
    /// </summary>
    public int Num { get; set; }

    /// <summary>
    /// 代碼
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 名稱(1-&gt;自取面交、2-&gt;外送面交、3-&gt;貨運宅配、4-&gt;超商取貨)
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 運費
    /// </summary>
    public decimal Fee { get; set; }

    /// <summary>
    /// 運費減免碼(Y-&gt;超過FreeAmt得享免運;N-&gt;不提供免運)
    /// </summary>
    public string FreeCode { get; set; } = null!;

    /// <summary>
    /// 免運滿額值
    /// </summary>
    public decimal FreeAmt { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public short Sort { get; set; }

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
