using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商家供應商
/// </summary>
public partial class MerSupplier
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
    /// 供應商分類序號(from MerSupCategory)
    /// </summary>
    public int MerSupCatId { get; set; }

    /// <summary>
    /// 統一編號
    /// </summary>
    public string? TaxId { get; set; }

    /// <summary>
    /// 供應商名稱
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// 聯絡電話
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// 手機號碼
    /// </summary>
    public string? Mobile { get; set; }

    /// <summary>
    /// 通訊地址
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// 聯絡人
    /// </summary>
    public string? Contacter { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int Sort { get; set; }

    /// <summary>
    /// 狀態(0-&gt;停權,1-&gt;使用中,9-&gt;刪除)
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
