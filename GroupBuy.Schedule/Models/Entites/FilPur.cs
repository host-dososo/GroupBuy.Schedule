using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 檔案用途
/// </summary>
public partial class FilPur
{
    /// <summary>
    /// 序號
    /// </summary>
    public byte Id { get; set; }

    /// <summary>
    /// 功能序號
    /// </summary>
    public int FunctionId { get; set; }

    /// <summary>
    /// 標題
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }
}
