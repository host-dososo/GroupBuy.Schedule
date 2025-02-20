using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 叫貨單
/// </summary>
public partial class PurchaseOrder
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 採購單號(from NumTable)
    /// </summary>
    public string Num { get; set; } = null!;

    /// <summary>
    /// 商家供應商序號
    /// </summary>
    public int MerSupId { get; set; }

    /// <summary>
    /// 運送金額(運費)
    /// </summary>
    public decimal ShipAmt { get; set; }

    /// <summary>
    /// 調整金額
    /// </summary>
    public decimal AdjAmt { get; set; }

    /// <summary>
    /// 總金額
    /// </summary>
    public decimal TotalAmt { get; set; }

    /// <summary>
    /// 預計到貨日
    /// </summary>
    public DateOnly EstArrDate { get; set; }

    /// <summary>
    /// 實際到貨(入庫)時間
    /// </summary>
    public DateTime ActArrTime { get; set; }

    /// <summary>
    /// 採購(叫貨)狀態(0:未到貨/1:已入庫/2:部分入庫/3:結單)
    /// </summary>
    public string PurStatus { get; set; } = null!;

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
