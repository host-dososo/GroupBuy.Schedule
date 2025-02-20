using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 倉庫交易紀錄
/// </summary>
public partial class WarHouTraLog
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 分倉序號
    /// </summary>
    public long WarHouBraId { get; set; }

    /// <summary>
    /// 類型(進項0/出項1/配進2/配出3/)
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// 種類(庫存調整0/叫貨1/出貨2/配貨3)
    /// </summary>
    public string Kind { get; set; } = null!;

    /// <summary>
    /// 庫存變更原因(代碼)
    /// </summary>
    public string ReaCode { get; set; } = null!;

    /// <summary>
    /// 來源編號
    /// </summary>
    public long SourceId { get; set; }

    /// <summary>
    /// 異動數量
    /// </summary>
    public decimal Qty { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 創建日期時間
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 創建人員
    /// </summary>
    public int Creator { get; set; }
}
