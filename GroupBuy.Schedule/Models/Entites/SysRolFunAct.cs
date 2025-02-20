using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 系統角色功能動作
/// </summary>
public partial class SysRolFunAct
{
    /// <summary>
    /// 系統角色序號
    /// </summary>
    public int SysRolId { get; set; }

    /// <summary>
    /// 系統功能序號
    /// </summary>
    public int SysFunId { get; set; }

    /// <summary>
    /// 系統動作代碼
    /// </summary>
    public string SysActCode { get; set; } = null!;
}
