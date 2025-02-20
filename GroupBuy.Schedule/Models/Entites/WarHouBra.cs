using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 分倉
/// </summary>
public partial class WarHouBra
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 商家倉庫序號
    /// </summary>
    public int WarHouMerId { get; set; }

    /// <summary>
    /// 商品規格序號
    /// </summary>
    public long GooSpecId { get; set; }

    /// <summary>
    /// 數量
    /// </summary>
    public decimal Qty { get; set; }

    /// <summary>
    /// 保留量
    /// </summary>
    public decimal RetQty { get; set; }

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
