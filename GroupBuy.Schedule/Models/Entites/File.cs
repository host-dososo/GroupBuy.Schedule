using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 檔案
/// </summary>
public partial class File
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 商家序號
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 來源表格序號
    /// </summary>
    public int SysTabId { get; set; }

    /// <summary>
    /// 來源資料列序號
    /// </summary>
    public long RowId { get; set; }

    /// <summary>
    /// 儲存名稱
    /// </summary>
    public string SaveName { get; set; } = null!;

    /// <summary>
    /// 原始名稱
    /// </summary>
    public string OrgName { get; set; } = null!;

    /// <summary>
    /// 檔案大小
    /// </summary>
    public int Size { get; set; }

    /// <summary>
    /// 副檔名
    /// </summary>
    public string? ExtName { get; set; }

    /// <summary>
    /// 檔案用途(詳見表:檔案用途與來源表格對照表)
    /// </summary>
    public byte FilPurId { get; set; }

    /// <summary>
    /// 檔案種類;1:圖檔/2:文件/3:音檔/4:影片/0:其他
    /// </summary>
    public byte FilKinId { get; set; }

    /// <summary>
    /// 是否主圖
    /// </summary>
    public bool IsMaster { get; set; }

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
