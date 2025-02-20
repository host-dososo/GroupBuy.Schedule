using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 系統動作
/// </summary>
public partial class SysAct
{
    /// <summary>
    /// 動作代碼
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 中文名稱
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 英文名稱
    /// </summary>
    public string EnName { get; set; } = null!;

    /// <summary>
    /// 是否開啟
    /// </summary>
    public bool? isOpen { get; set; }
}
