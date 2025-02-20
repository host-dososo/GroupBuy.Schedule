using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_MemRegConfig
{
    public string? TypeFullCode { get; set; }

    public int Id { get; set; }

    public int MerchantId { get; set; }

    public int? SocTypeId { get; set; }

    public string ConfigTypeCode { get; set; } = null!;

    public string? Name { get; set; }

    public string? Value { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public int? Creator { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? Updater { get; set; }

    public string Code { get; set; } = null!;

    public string TypeName { get; set; } = null!;

    public byte Step { get; set; }

    public string Remark { get; set; } = null!;

    public string TypeStatus { get; set; } = null!;
}
