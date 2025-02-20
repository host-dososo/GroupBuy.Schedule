using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商家會員
/// </summary>
public partial class MerMember
{
    public int MerchantId { get; set; }

    public int MemberId { get; set; }

    /// <summary>
    /// 會員編號(from NumTable)
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// 會員類型代碼(from MemType)
    /// </summary>
    public string MemTypCode { get; set; } = null!;

    /// <summary>
    /// 預設交貨方式(From MerShiWay)
    /// </summary>
    public int MerShiWayId { get; set; }

    /// <summary>
    /// 預設付款方式(From MerPayType)
    /// </summary>
    public int MerPayTypId { get; set; }

    /// <summary>
    /// 預設取貨點(From MerPicPoint)
    /// </summary>
    public int? MerPicPoiId { get; set; }

    /// <summary>
    /// 購物金
    /// </summary>
    public decimal? ShopAmt { get; set; }

    /// <summary>
    /// 紅利點數(trigger)
    /// </summary>
    public int? BonusPoint { get; set; }

    /// <summary>
    /// 未到貨數量(trigger)
    /// </summary>
    public decimal? QtyNonArvl { get; set; }

    /// <summary>
    /// 未取貨數量(trigger)
    /// </summary>
    public decimal? QtyNonTake { get; set; }

    /// <summary>
    /// 未結單金額(trigger)
    /// </summary>
    public decimal? AmtNonPay { get; set; }

    /// <summary>
    /// 最新成交日期(trigger)
    /// </summary>
    public DateOnly? LastDealDate { get; set; }

    public bool? IsVip { get; set; }

    /// <summary>
    /// 推薦人ID
    /// </summary>
    public int? RefMemberId { get; set; }

    /// <summary>
    /// 推薦人商家
    /// </summary>
    public int? RefMerchantId { get; set; }

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
