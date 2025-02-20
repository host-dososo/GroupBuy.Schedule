using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// SP錯誤紀錄
/// </summary>
public partial class ErrorLogCashAmt
{
    /// <summary>
    /// 序號
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// 日期
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// 時間
    /// </summary>
    public TimeOnly Time { get; set; }

    /// <summary>
    /// 錯誤程序名稱
    /// </summary>
    public string Type { get; set; } = null!;

    public long SourceId { get; set; }

    public string? SourceType { get; set; }

    /// <summary>
    /// 商家序號
    /// </summary>
    public int? MerchantId { get; set; }

    /// <summary>
    /// 操作人員序號
    /// </summary>
    public int? OperatorId { get; set; }

    /// <summary>
    /// 參數值(各參數以&apos;#^&apos;串接)
    /// </summary>
    public string? ParamValues { get; set; }

    /// <summary>
    /// 解決時間
    /// </summary>
    public DateOnly? SolveDate { get; set; }

    /// <summary>
    /// 解決狀態
    /// </summary>
    public string? SolveStatus { get; set; }
}
