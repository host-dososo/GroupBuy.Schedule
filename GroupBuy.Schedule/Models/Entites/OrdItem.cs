using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 訂單項目
/// </summary>
public partial class OrdItem
{
    /// <summary>
    /// 訂單明細序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 訂單序號(from Order)
    /// </summary>
    public long OrderId { get; set; }

    /// <summary>
    /// 商品序號(from Goods)
    /// </summary>
    public long GoodsId { get; set; }

    /// <summary>
    /// 商品名稱(from Goods)
    /// </summary>
    public string GoodsName { get; set; } = null!;

    /// <summary>
    /// 商品介紹(from Goods)
    /// </summary>
    public string? GoodsDescription { get; set; }

    /// <summary>
    /// 商家供應商序號(from MerSupplier)
    /// </summary>
    public int MerSupId { get; set; }

    /// <summary>
    /// 商家社群頻道序號(from MerSocChannel)
    /// </summary>
    public int? MerSocChaId { get; set; }

    /// <summary>
    /// 商家社群頻道名稱(from MerSocChannel)
    /// </summary>
    public string? MerSocChaName { get; set; }

    /// <summary>
    /// 圖組序號(from Group)
    /// </summary>
    public long? GroupId { get; set; }

    /// <summary>
    /// 團名主標(from Group)
    /// </summary>
    public string? Title1 { get; set; }

    /// <summary>
    /// 團組商品序號(from GroGoods)
    /// </summary>
    public long? GroGooId { get; set; }

    /// <summary>
    /// 團組商品折扣序號(from GroGooOfr)
    /// </summary>
    public long? GroGooOfrId { get; set; }

    /// <summary>
    /// 適用會員類型(0-&gt;全部適用,1:一般/2:批客/3:過路客 from MemType)(from GroGooOfr)
    /// </summary>
    public string? MemTypeCode { get; set; }

    /// <summary>
    /// 商品折扣起訂數量 (from GooOfr)
    /// </summary>
    public decimal? GooOfrQty { get; set; }

    /// <summary>
    /// 商品折扣優惠選項代碼(1-&gt;每件減固定金額, 2-&gt;整單折扣)(from GooOfr)
    /// </summary>
    public string? OptionCode { get; set; }

    /// <summary>
    /// 商品折扣減收金額(from GroGooOfr)
    /// </summary>
    public decimal? DiscountAmt { get; set; }

    /// <summary>
    /// 商品折扣減收折扣(from GroGooOfr)
    /// </summary>
    public decimal? DiscountPct { get; set; }

    /// <summary>
    /// 預計到貨日(from Group)
    /// </summary>
    public DateTime? GroArriveTime { get; set; }

    /// <summary>
    /// 叫貨日期(from Group)
    /// </summary>
    public DateTime? GroVenOrdTime { get; set; }

    /// <summary>
    /// 合計數量
    /// </summary>
    public decimal SumTolQty { get; set; }

    /// <summary>
    /// 合計金額
    /// </summary>
    public decimal SumTolAmt { get; set; }

    /// <summary>
    /// 合計應收金額
    /// </summary>
    public decimal SumShpTolAmt { get; set; }
}
