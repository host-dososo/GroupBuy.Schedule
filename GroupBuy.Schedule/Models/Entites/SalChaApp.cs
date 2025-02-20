using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class SalChaApp
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 應用程式名稱
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 銷售渠道Id
    /// </summary>
    public int? SalChaId { get; set; }

    /// <summary>
    /// 社群類型
    /// </summary>
    public int? SocType { get; set; }

    /// <summary>
    /// AppId
    /// </summary>
    public string? AppId { get; set; }

    /// <summary>
    /// AppSecret
    /// </summary>
    public string? AppSecret { get; set; }

    public string? CallbackUrl { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int Sort { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 狀態(0-&gt;停用,1-&gt;使用中,9-&gt;刪除)
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// 創建日期時間
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 創建人員
    /// </summary>
    public int Creator { get; set; }

    /// <summary>
    /// 更新日期時間
    /// </summary>
    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// 更新人員
    /// </summary>
    public int? Updater { get; set; }
}
