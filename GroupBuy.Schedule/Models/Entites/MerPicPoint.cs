using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商家取貨點
/// </summary>
public partial class MerPicPoint
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 商家序號(from Merchant)
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 編號(from NumTable)
    /// </summary>
    public int Num { get; set; }

    /// <summary>
    /// 取貨點名稱
    /// </summary>
    public string Name { get; set; } = null!;

    public int MerPicPoiTypeId { get; set; }

    /// <summary>
    /// 取貨點地址
    /// </summary>
    public string Address { get; set; } = null!;

    /// <summary>
    /// 聯絡人
    /// </summary>
    public string Contacter { get; set; } = null!;

    /// <summary>
    /// 聯絡電話
    /// </summary>
    public string Phone { get; set; } = null!;

    /// <summary>
    /// 取貨時間
    /// </summary>
    public string OpenTime { get; set; } = null!;

    /// <summary>
    /// 取貨點分潤成數
    /// </summary>
    public decimal SharePct { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Memo { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int Sort { get; set; }

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
