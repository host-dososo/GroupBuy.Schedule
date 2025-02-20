using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 團組
/// </summary>
public partial class Group
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 所屬商家序號(from Merchant)
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 編號
    /// </summary>
    public int? Num { get; set; }

    /// <summary>
    /// 團名主標
    /// </summary>
    public string Title1 { get; set; } = null!;

    /// <summary>
    /// 團名副標
    /// </summary>
    public string? Title2 { get; set; }

    /// <summary>
    /// 是否手動(快速)關團(0-&gt;否,1-&gt;是)
    /// </summary>
    public string IsHandOff { get; set; } = null!;

    /// <summary>
    /// 是否為Vip團
    /// </summary>
    public bool IsVip { get; set; }

    /// <summary>
    /// 訂單數量
    /// </summary>
    public int OrderAmount { get; set; }

    /// <summary>
    /// 開團數量
    /// </summary>
    public decimal Qty { get; set; }

    /// <summary>
    /// 預計到貨日
    /// </summary>
    public DateTime? ArriveTime { get; set; }

    /// <summary>
    /// 開團時間
    /// </summary>
    public DateTime Beginning { get; set; }

    /// <summary>
    /// 結團時間
    /// </summary>
    public DateTime Ending { get; set; }

    /// <summary>
    /// 叫貨時間
    /// </summary>
    public DateTime? VenOrdTime { get; set; }

    /// <summary>
    /// 叫貨狀態(0-&gt;未叫貨,1-&gt;已叫貨,2-&gt;無須叫貨)
    /// </summary>
    public string? VenOrdSta { get; set; }

    /// <summary>
    /// 最後到貨時間
    /// </summary>
    public DateTime? LasStoTime { get; set; }

    /// <summary>
    /// 到貨狀態(0-&gt;未到貨,1-&gt;已到貨,2-&gt;部分到貨)
    /// </summary>
    public string? LasStoSta { get; set; }

    /// <summary>
    /// 貼文綁定代碼
    /// </summary>
    public string? FeedCode { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Memo { get; set; }

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
