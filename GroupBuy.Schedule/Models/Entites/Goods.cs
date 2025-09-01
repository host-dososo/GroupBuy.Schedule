using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商品
/// </summary>
public partial class Goods
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 商家序號(from Merchant)
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 商品編號(from NumTable)
    /// </summary>
    public string Num { get; set; } = null!;

    /// <summary>
    /// 商品次分類序號(from GoodsCategory)
    /// </summary>
    public int GooCat2Id { get; set; }

    /// <summary>
    /// 商品名稱
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 進價
    /// </summary>
    public decimal PriceBuy { get; set; }

    /// <summary>
    /// 售價
    /// </summary>
    public decimal PriceSell { get; set; }

    /// <summary>
    /// 一個會員最多只能買多少個
    /// </summary>
    public decimal? BuyMaxCnt { get; set; }

    public decimal? LastPrice { get; set; }

    /// <summary>
    /// 商品介紹
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 上架時間
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// 下架時間
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// 禁用下單
    /// </summary>
    public bool DisOrder { get; set; }

    /// <summary>
    /// 禁用下單原因
    /// </summary>
    public string? DisOrderRsn { get; set; }

    /// <summary>
    /// 禁用下單洽詢客服社群 (對應 MerVariable)
    /// </summary>
    public int? DisOrdSocVarKey { get; set; }

    /// <summary>
    /// 是否開啓預購(0-&gt;關閉/1-&gt;開啓)
    /// </summary>
    public bool PreOrder { get; set; }

    /// <summary>
    /// 是否置頂(0:否/1:是)
    /// </summary>
    public bool IsTop { get; set; }

    /// <summary>
    /// 該商品建立於批貨商的某個商品
    /// </summary>
    public long? SupGooId { get; set; }

    /// <summary>
    /// 該商品建立於最上層批貨商的某個商品
    /// </summary>
    public long? RootSupGooId { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

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
