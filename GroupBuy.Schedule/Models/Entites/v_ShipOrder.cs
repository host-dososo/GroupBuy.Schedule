using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_ShipOrder
{
    public long Id { get; set; }

    public string Number { get; set; } = null!;

    public string OrdTypCode { get; set; } = null!;

    public string OrdStaCode { get; set; } = null!;

    public string? OrdPayStaCode { get; set; }

    public string? OrdDebitCode { get; set; }

    public string? OrdCanCode { get; set; }

    public string OrdSocType { get; set; } = null!;

    public int MerchantId { get; set; }

    public string MemTypCode { get; set; } = null!;

    public int MemberId { get; set; }

    public string? MemReaName { get; set; }

    public int? MerSocChaId { get; set; }

    public string? MerSocChaName { get; set; }

    public string? SocCommentId { get; set; }

    public string BuyName { get; set; } = null!;

    public string? BuyTel { get; set; }

    public string? BuyEmail { get; set; }

    public string? BuyCouCode { get; set; }

    public string? BuyCitcode { get; set; }

    public string? BuyPosCode { get; set; }

    public string? BuyPosName { get; set; }

    public string? BuyAddress { get; set; }

    public string? RecName { get; set; }

    public string? RecTel { get; set; }

    public string? RecEmail { get; set; }

    public string? RecCouCode { get; set; }

    public string? RecCitCode { get; set; }

    public string? RecPosCode { get; set; }

    public string? RecPosName { get; set; }

    public string? RecAddress { get; set; }

    public string? UniTitle { get; set; }

    public string? UniCode { get; set; }

    public string? AuthCode { get; set; }

    public decimal OrdTolQty { get; set; }

    public decimal? GetTolQty { get; set; }

    public decimal? ShpTolQty { get; set; }

    public decimal? OriOrdTolAmt { get; set; }

    public decimal? OfrTolAmt { get; set; }

    public decimal? OrdTolAmt { get; set; }

    public decimal? ShpTolAmt { get; set; }

    public decimal? DebitAmt { get; set; }

    public decimal? RecTolAmt { get; set; }

    public decimal? ShopAmt { get; set; }

    public decimal? ShortAmt { get; set; }

    public int MerPayTypId { get; set; }

    public int MerShiWayId { get; set; }

    public int? MerPicPoiId { get; set; }

    public DateTime? PayTime { get; set; }

    public long? PicUpId { get; set; }

    public decimal ShipFee { get; set; }

    public int BonPoiUse { get; set; }

    public int BonPoiGet { get; set; }

    public decimal BpDisAmount { get; set; }

    public int? SplSouId { get; set; }

    public DateTime? SplitTime { get; set; }

    public DateTime OrderTime { get; set; }

    public DateTime? VenOrdTime { get; set; }

    public DateTime? ArrivalTime { get; set; }

    public DateTime? GetTime { get; set; }

    public DateTime? CanTime { get; set; }

    public DateTime? OutTime { get; set; }

    public DateTime? DeliverTime { get; set; }

    public string? MemPickUpCode { get; set; }

    public string? Memo { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public int Creator { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Updater { get; set; }

    public string? PickFormNum { get; set; }

    public DateTime? PickTime { get; set; }

    public int? PickUpMerShiWayId { get; set; }

    public int? PickUpMerPayTypId { get; set; }

    public int? PickUpMerPicPoiId { get; set; }

    public long? PicPoiDelivId { get; set; }

    public long ShipId { get; set; }

    public string? ShipFormNum { get; set; }

    public int? ShipMerShiWayId { get; set; }

    public int? ShipMerPayTypId { get; set; }

    public int? ShipMerPicPoiId { get; set; }

    public decimal? TolOriOrdTolAmt { get; set; }

    public decimal? TolOrdShopAmt { get; set; }

    public decimal? TolOrdDebitAmt { get; set; }

    public decimal? TolOrdRectolAmt { get; set; }

    public decimal? TolOrdOfrAmt { get; set; }

    public decimal? TolOrdShortAmt { get; set; }

    public decimal? ShipDebitAmt { get; set; }

    public decimal? ShipShipFee { get; set; }

    public decimal ShipRecTolAmt { get; set; }

    public decimal? ShipShopAmt { get; set; }

    public string Check { get; set; } = null!;

    public DateTime? ShipTime { get; set; }

    public string ShipPayStaCode { get; set; } = null!;

    public string? ShipMemo { get; set; }

    public DateTime? ShipCreatedTime { get; set; }
}
