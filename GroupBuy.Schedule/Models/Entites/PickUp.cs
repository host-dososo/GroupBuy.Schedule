using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 揀貨單號資料
/// </summary>
public partial class PickUp
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 揀貨單號,流水號8碼(ex:0000001)
    /// </summary>
    public string? Number { get; set; }

    public long? ShipId { get; set; }

    /// <summary>
    /// 取貨點配送單ID
    /// </summary>
    public long? PicPoiDelivId { get; set; }

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
    /// 出貨運費
    /// </summary>
    public decimal? ShipFee { get; set; }

    /// <summary>
    /// 輸入類別(0:選擇,1:手動)
    /// </summary>
    public bool? RecNamInpType { get; set; }

    /// <summary>
    /// 輸入類別(0:選擇,1:手動)
    /// </summary>
    public bool? RecAddrInpType { get; set; }

    /// <summary>
    /// 完成揀貨時間
    /// </summary>
    public DateTime? PickTime { get; set; }

    /// <summary>
    /// 創建時間
    /// </summary>
    public DateTime? CreatedTime { get; set; }

    /// <summary>
    /// 新增至取貨點配送單時間
    /// </summary>
    public DateTime? PicPoiDelivTime { get; set; }
}
