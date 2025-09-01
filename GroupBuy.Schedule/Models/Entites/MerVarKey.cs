using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商家設定檔Key
/// </summary>
public partial class MerVarKey
{
    public int Id { get; set; }

    public int Num { get; set; }

    /// <summary>
    /// 所屬系統(3:取貨點管理平台/2:所有/1:商家管理/0:系統管理)
    /// </summary>
    public string OwnSys { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? DefValue { get; set; }

    /// <summary>
    /// 商家註冊完是否直接新增
    /// </summary>
    public bool DefAdd { get; set; }

    /// <summary>
    /// 設定檔描述
    /// </summary>
    public string? Description { get; set; }

    public string? Unit { get; set; }
}
