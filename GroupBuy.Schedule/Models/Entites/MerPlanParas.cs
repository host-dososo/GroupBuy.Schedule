using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class MerPlanParas
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 商家方案代碼(參閱 MerPlan)
    /// </summary>
    public string? MerPlanCode { get; set; }

    /// <summary>
    /// 管理型態
    /// </summary>
    public string? ManType { get; set; }

    /// <summary>
    /// 系統功能Id
    /// </summary>
    public int? SysFunId { get; set; }

    /// <summary>
    /// 方案參數名稱
    /// </summary>
    public string? ParaName { get; set; }

    /// <summary>
    /// 方案參數值
    /// </summary>
    public string? ParaValue { get; set; }
}
