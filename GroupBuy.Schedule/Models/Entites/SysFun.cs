using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 系統功能
/// </summary>
public partial class SysFun
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 所屬系統(1:商家管理/0:系統管理)
    /// </summary>
    public string OwnSys { get; set; } = null!;

    /// <summary>
    /// 中文名稱
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 父階層序號
    /// </summary>
    public int? Father { get; set; }

    /// <summary>
    /// 是否為可操作頁面(0-&gt;否,1-&gt;是)
    /// </summary>
    public bool? IsItem { get; set; }

    /// <summary>
    /// 頁面網址
    /// </summary>
    public string? PageURL { get; set; }

    /// <summary>
    /// 頁面英文名稱
    /// </summary>
    public string? EnName { get; set; }

    /// <summary>
    /// 是否開啟(0-&gt;否,1-&gt;是)
    /// </summary>
    public bool? isOpen { get; set; }

    /// <summary>
    /// 頁面排序
    /// </summary>
    public int? Sort { get; set; }

    public string? ClassName { get; set; }
}
