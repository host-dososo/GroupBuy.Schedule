using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// SP錯誤紀錄
/// </summary>
public partial class ErrorLogSp
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
    /// 錯誤嚴重性
    /// </summary>
    public string Severity { get; set; } = null!;

    /// <summary>
    /// 錯誤代碼
    /// </summary>
    public string Number { get; set; } = null!;

    /// <summary>
    /// 錯誤程序名稱
    /// </summary>
    public string Procedure { get; set; } = null!;

    /// <summary>
    /// 錯誤行號
    /// </summary>
    public string Line { get; set; } = null!;

    /// <summary>
    /// 錯誤訊息
    /// </summary>
    public string Message { get; set; } = null!;

    /// <summary>
    /// 錯誤狀態號碼
    /// </summary>
    public string State { get; set; } = null!;

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
