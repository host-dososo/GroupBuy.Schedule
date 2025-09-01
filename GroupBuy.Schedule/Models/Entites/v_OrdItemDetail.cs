using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_OrdItemDetail
{
    public long OrderId { get; set; }

    public int MerchantId { get; set; }

    public string Number { get; set; } = null!;

    public string OrdStaName { get; set; } = null!;

    public string OrdTypName { get; set; } = null!;

    public string MerShiWayName { get; set; } = null!;

    public string? MerPicPoiName { get; set; }

    public string? MerPayTypName { get; set; }

    public int MerPayTypId { get; set; }

    public int MerShiWayId { get; set; }

    public int? MerPicPoiId { get; set; }

    public int MerShiWayNum { get; set; }

    public string OrdStaCode { get; set; } = null!;

    public string OrdTypCode { get; set; } = null!;

    public string? OrdPayStaCode { get; set; }

    public string? MemReaName { get; set; }

    public string BuyName { get; set; } = null!;

    public string? BuyTel { get; set; }

    public string? BuyEmail { get; set; }

    public string? RecName { get; set; }

    public string? RecTel { get; set; }

    public string? RecEmail { get; set; }

    public string? RecCouCode { get; set; }

    public string? RecCitCode { get; set; }

    public string? GiCitName { get; set; }

    public string? RecPosCode { get; set; }

    public string? RecPosName { get; set; }

    public string? RecAddress { get; set; }

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

    public DateTime CreatedTime { get; set; }

    public string? Memo { get; set; }

    public long? GoodsId { get; set; }

    public string? GoodsName { get; set; }

    public long GooSpeId { get; set; }

    public string GooSpeName { get; set; } = null!;

    public decimal GooSpePriceSell { get; set; }

    public decimal? GroGooSpePriceSell { get; set; }

    public decimal Qty { get; set; }

    public decimal? RetQty { get; set; }

    public decimal SubTolAmt { get; set; }

    public long? GroGooSpeId { get; set; }

    public int? MerSocChaId { get; set; }

    public int MemberId { get; set; }

    public string Status { get; set; } = null!;

    public long? GroupId { get; set; }
}
