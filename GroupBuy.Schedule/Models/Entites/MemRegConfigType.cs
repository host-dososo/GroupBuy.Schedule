using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 會員註冊設定檔種類
/// </summary>
public partial class MemRegConfigType
{
    /// <summary>
    /// 代碼
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 名稱
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 註冊步驟 (第幾步驟)
    /// </summary>
    public byte Step { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string Remark { get; set; } = null!;

    /// <summary>
    /// 狀態 1:正常 0:停用 9:刪除
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// 創建日期時間
    /// </summary>
    public DateTime? CreatedTime { get; set; }

    /// <summary>
    /// 創建人員
    /// </summary>
    public int? Creator { get; set; }

    /// <summary>
    /// 更新日期時間
    /// </summary>
    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// 更新人員
    /// </summary>
    public int? Updater { get; set; }
}
