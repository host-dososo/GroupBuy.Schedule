using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 出貨單號資料
/// </summary>
public partial class Shipment
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 出貨單號,流水號8碼(ex:0000001)
    /// </summary>
    public string? Number { get; set; }

    /// <summary>
    /// 出貨單編碼(8碼)
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 會員序號
    /// </summary>
    public int? MemberId { get; set; }

    /// <summary>
    /// 訂購人名稱
    /// </summary>
    public string? BuyName { get; set; }

    /// <summary>
    /// 收貨人名稱
    /// </summary>
    public string? RecName { get; set; }

    /// <summary>
    /// 收件人連絡電話
    /// </summary>
    public string? RecTel { get; set; }

    /// <summary>
    /// 收件人國家代碼(From GiCountry)
    /// </summary>
    public string? RecCouCode { get; set; }

    /// <summary>
    /// 收件人縣市代碼(From GiCity)
    /// </summary>
    public string? RecCitCode { get; set; }

    /// <summary>
    /// 收件人鄉鎮市區代碼(From GiPostCode)
    /// </summary>
    public string? RecPosCode { get; set; }

    /// <summary>
    /// 收件人鄉鎮區域名
    /// </summary>
    public string? RecPosName { get; set; }

    /// <summary>
    /// 收貨人地址
    /// </summary>
    public string? RecAddress { get; set; }

    /// <summary>
    /// 收貨方式
    /// </summary>
    public int? MerShiWayId { get; set; }

    /// <summary>
    /// 付款方式
    /// </summary>
    public int? MerPayTypId { get; set; }

    /// <summary>
    /// 取貨點序號
    /// </summary>
    public int? MerPicPoiId { get; set; }

    /// <summary>
    /// 原始訂單金額(=各商品項目售價x數量的總和)
    /// </summary>
    public decimal? TolOriOrdTolAmt { get; set; }

    /// <summary>
    /// 合計訂單購物金
    /// </summary>
    public decimal? TolOrdShopAmt { get; set; }

    /// <summary>
    /// 合計訂單折讓金額
    /// </summary>
    public decimal? TolOrdDebitAmt { get; set; }

    /// <summary>
    /// 合計訂單實收款
    /// </summary>
    public decimal? TolOrdRectolAmt { get; set; }

    /// <summary>
    /// 合計訂單欠款
    /// </summary>
    public decimal? TolOrdShortAmt { get; set; }

    public decimal? TolOrdOfrAmt { get; set; }

    /// <summary>
    /// 折讓金額
    /// </summary>
    public decimal? DebitAmt { get; set; }

    /// <summary>
    /// 實收金額(已收金額)
    /// </summary>
    public decimal RecTolAmt { get; set; }

    /// <summary>
    /// 出貨運費(應補收運費)
    /// </summary>
    public decimal? ShipFee { get; set; }

    /// <summary>
    /// 購物金
    /// </summary>
    public decimal? ShopAmt { get; set; }

    /// <summary>
    /// 名稱輸入類別(0:選擇,1:手動)
    /// </summary>
    public bool? RecNamInpType { get; set; }

    /// <summary>
    /// 地址輸入類別(0:選擇,1:手動)
    /// </summary>
    public bool? RecAddrInpType { get; set; }

    /// <summary>
    /// 收款狀態(0-&gt;未收款;1-&gt;已收款;2-&gt;部分收款)
    /// </summary>
    public string ShipPayStaCode { get; set; } = null!;

    /// <summary>
    /// 是否結單(0-&gt;未結單;1-&gt;已結單)
    /// </summary>
    public string Check { get; set; } = null!;

    /// <summary>
    /// 出貨時間
    /// </summary>
    public DateTime? ShipTime { get; set; }

    /// <summary>
    /// 備注
    /// </summary>
    public string? Memo { get; set; }

    /// <summary>
    /// 創建時間
    /// </summary>
    public DateTime? CreatedTime { get; set; }
}
