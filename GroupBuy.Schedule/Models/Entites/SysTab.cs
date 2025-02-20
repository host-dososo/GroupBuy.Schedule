using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 系統資料表格
/// </summary>
public partial class SysTab
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Catalog
    /// </summary>
    public string Catalog { get; set; } = null!;

    /// <summary>
    /// Schema
    /// </summary>
    public string Schema { get; set; } = null!;

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// 狀態
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// 建立/編輯 時間
    /// </summary>
    public DateTime Date { get; set; }
}
