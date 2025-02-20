using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 會員購物金記錄
/// </summary>
public partial class CashAmtLog
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 商家序號
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 會員序號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 類型(進項0/出項1)
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// 種類(購物金0/訂單1)
    /// </summary>
    public string Kind { get; set; } = null!;

    /// <summary>
    /// 原因代碼
    /// </summary>
    public string? ReaCode { get; set; }

    /// <summary>
    /// 編號/單號
    /// </summary>
    public string? Number { get; set; }

    /// <summary>
    /// 金額
    /// </summary>
    public decimal Amt { get; set; }

    /// <summary>
    /// 備注
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 創建日期時間
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 創建人員
    /// </summary>
    public int? Creator { get; set; }
}
