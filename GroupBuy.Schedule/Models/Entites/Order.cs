using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 訂單
/// </summary>
public partial class Order
{
    /// <summary>
    /// 序號
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// 訂單單號(流水號8碼;ex:00000001)
    /// </summary>
    public string Number { get; set; } = null!;

    /// <summary>
    /// 訂單類型代碼(G:團購訂單/S:現場加單/M:手動訂單...更多參考：OrdType)
    /// </summary>
    public string OrdTypCode { get; set; } = null!;

    /// <summary>
    /// 訂單狀態代碼(1:待配貨/2:/3:待揀貨/4:待出貨/5:已出貨(訂單完成)/6:結單/8:取消/9:棄單/0:斷貨)
    /// </summary>
    public string OrdStaCode { get; set; } = null!;

    /// <summary>
    /// 收款狀態代碼(0-&gt;未收款;1-&gt;已收款)
    /// </summary>
    public string? OrdPayStaCode { get; set; }

    /// <summary>
    /// 折讓訂單代碼
    /// </summary>
    public string? OrdDebitCode { get; set; }

    /// <summary>
    /// 訂單取消代碼
    /// </summary>
    public string? OrdCanCode { get; set; }

    /// <summary>
    /// 訂單類別：(0-&gt;非社群訂單(ex.賣場訂單), 1-&gt;FB留言自動轉訂單, 2-&gt;FB留言手動轉訂單)
    /// </summary>
    public string OrdSocType { get; set; } = null!;

    /// <summary>
    /// 商家序號(from Merchant)
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 會員類型(1:一般會員/2:批客/3:門市顧客 from MerMember)
    /// </summary>
    public string MemTypCode { get; set; } = null!;

    /// <summary>
    /// 會員序號(from Member)
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 會員真實姓名
    /// </summary>
    public string? MemReaName { get; set; }

    /// <summary>
    /// 商家社群頻道序號(from MerSocChannel：Id)
    /// </summary>
    public int? MerSocChaId { get; set; }

    /// <summary>
    /// 商家社群頻道名稱(from MerSocChannel：Name)
    /// </summary>
    public string? MerSocChaName { get; set; }

    /// <summary>
    /// 社群留言Comment ID
    /// </summary>
    public string? SocCommentId { get; set; }

    /// <summary>
    /// 購買人姓名
    /// </summary>
    public string BuyName { get; set; } = null!;

    /// <summary>
    /// 購買人連絡電話
    /// </summary>
    public string? BuyTel { get; set; }

    /// <summary>
    /// 購買人email
    /// </summary>
    public string? BuyEmail { get; set; }

    /// <summary>
    /// 購買人國家代碼(From GiCountry)
    /// </summary>
    public string? BuyCouCode { get; set; }

    /// <summary>
    /// 購買人縣市代碼(From GiCity)
    /// </summary>
    public string? BuyCitcode { get; set; }

    /// <summary>
    /// 購買人鄉鎮市區代碼(From GiPostCode)
    /// </summary>
    public string? BuyPosCode { get; set; }

    /// <summary>
    /// 購買人鄉鎮區域名
    /// </summary>
    public string? BuyPosName { get; set; }

    /// <summary>
    /// 購買人地址
    /// </summary>
    public string? BuyAddress { get; set; }

    /// <summary>
    /// 收件人姓名
    /// </summary>
    public string? RecName { get; set; }

    /// <summary>
    /// 收件人連絡電話
    /// </summary>
    public string? RecTel { get; set; }

    /// <summary>
    /// 收件人email
    /// </summary>
    public string? RecEmail { get; set; }

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
    /// 收件人地址
    /// </summary>
    public string? RecAddress { get; set; }

    /// <summary>
    /// 發票抬頭
    /// </summary>
    public string? UniTitle { get; set; }

    /// <summary>
    /// 發票統一編號
    /// </summary>
    public string? UniCode { get; set; }

    /// <summary>
    /// 授權號碼
    /// </summary>
    public string? AuthCode { get; set; }

    /// <summary>
    /// 訂購數量
    /// </summary>
    public decimal OrdTolQty { get; set; }

    /// <summary>
    /// 已配貨量
    /// </summary>
    public decimal? GetTolQty { get; set; }

    /// <summary>
    /// 實際出貨量
    /// </summary>
    public decimal? ShpTolQty { get; set; }

    /// <summary>
    /// 原始訂單金額(=各商品項目售價x數量的總和)
    /// </summary>
    public decimal? OriOrdTolAmt { get; set; }

    /// <summary>
    /// 折扣優惠總額(=各商品售價x數量的總和)
    /// </summary>
    public decimal? OfrTolAmt { get; set; }

    /// <summary>
    /// 訂單總額(=原始訂單金額-折扣優惠總額+運費)
    /// </summary>
    public decimal? OrdTolAmt { get; set; }

    /// <summary>
    /// 應收金額(=訂單總額-(紅利折抵金額+折讓金額)=實收金額+欠款金額)
    /// </summary>
    public decimal? ShpTolAmt { get; set; }

    /// <summary>
    /// 折讓金額
    /// </summary>
    public decimal? DebitAmt { get; set; }

    /// <summary>
    /// 實收金額(已收金額)
    /// </summary>
    public decimal? RecTolAmt { get; set; }

    /// <summary>
    /// 購物金(已收金額)
    /// </summary>
    public decimal? ShopAmt { get; set; }

    /// <summary>
    /// 欠款金額
    /// </summary>
    public decimal? ShortAmt { get; set; }

    /// <summary>
    /// 付款方式序號(from MerPayType)
    /// </summary>
    public int MerPayTypId { get; set; }

    /// <summary>
    /// 取貨方式序號(from MerShiWay)
    /// </summary>
    public int MerShiWayId { get; set; }

    /// <summary>
    /// 取貨點序號(from MerPickPoint)
    /// </summary>
    public int? MerPicPoiId { get; set; }

    /// <summary>
    /// 收款日期
    /// </summary>
    public DateTime? PayTime { get; set; }

    public long? PicUpId { get; set; }

    /// <summary>
    /// 運費
    /// </summary>
    public decimal ShipFee { get; set; }

    /// <summary>
    /// 使用紅利點數
    /// </summary>
    public int BonPoiUse { get; set; }

    /// <summary>
    /// 取得紅利點數(若該訂單使用紅利點數折抵金額則不計算該訂單取得紅利點數)
    /// </summary>
    public int BonPoiGet { get; set; }

    /// <summary>
    /// 紅利點數折抵金額
    /// </summary>
    public decimal BpDisAmount { get; set; }

    /// <summary>
    /// 拆單序號來源
    /// </summary>
    public int? SplSouId { get; set; }

    /// <summary>
    /// 拆單時間
    /// </summary>
    public DateTime? SplitTime { get; set; }

    /// <summary>
    /// 訂購日期
    /// </summary>
    public DateTime OrderTime { get; set; }

    /// <summary>
    /// 叫貨日期
    /// </summary>
    public DateTime? VenOrdTime { get; set; }

    /// <summary>
    /// 到貨時間
    /// </summary>
    public DateTime? ArrivalTime { get; set; }

    /// <summary>
    /// 配貨日期
    /// </summary>
    public DateTime? GetTime { get; set; }

    /// <summary>
    /// 棄單日期
    /// </summary>
    public DateTime? CanTime { get; set; }

    /// <summary>
    /// 斷貨日期
    /// </summary>
    public DateTime? OutTime { get; set; }

    /// <summary>
    /// 配送(取貨點)時間
    /// </summary>
    public DateTime? DeliverTime { get; set; }

    /// <summary>
    /// 會員取貨編號
    /// </summary>
    public string? MemPickUpCode { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Memo { get; set; }

    /// <summary>
    /// 狀態(0-&gt;停用,1-&gt;使用中,9-&gt;刪除)
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// 創建日期時間(訂購日(訂單成立時間))
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
