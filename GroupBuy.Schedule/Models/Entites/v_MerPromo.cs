using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_MerPromo
{
    public int Id { get; set; }

    public int MerchantId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public string ActTgtName { get; set; } = null!;

    public int PromoCondId { get; set; }

    public int? PromoOrdActId { get; set; }

    public string? ActLocName { get; set; }

    public byte? ActLoc { get; set; }

    public decimal? ActValue { get; set; }

    public byte? ActValueType { get; set; }

    public string? ActValueTypeName { get; set; }

    public string? ActUnit { get; set; }

    public int PromoTgtId { get; set; }

    public int PromoRewardId { get; set; }

    public string? RewTypeName { get; set; }

    public decimal RewValue { get; set; }

    public decimal? RewLimit { get; set; }

    public string? RewUnit { get; set; }

    public int RewTypeId { get; set; }

    public string PromoTgtName { get; set; } = null!;

    public byte LimitTypeId { get; set; }

    public string? LimitTypeName { get; set; }

    public decimal LimitValue { get; set; }

    public string? LimitUnit { get; set; }

    public string PromoStatus { get; set; } = null!;

    public string PromoStatusName { get; set; } = null!;

    public bool? IsRegAct { get; set; }

    public int ActTgtId { get; set; }

    public byte? RewMtdType { get; set; }

    public byte? RewMtdCouType { get; set; }

    public string? RewMtdName { get; set; }

    public string? RewMtdCheckCode { get; set; }

    public int? RewMtdId { get; set; }

    public string? RewMtdTypeName { get; set; }

    public string? RewMtdCouTypName { get; set; }

    public bool? AutoAdjWar { get; set; }
}
