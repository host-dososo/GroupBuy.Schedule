using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_MerNotice
{
    public decimal Id { get; set; }

    public int MerchantId { get; set; }

    public int? SysFunActId { get; set; }

    public string? Data { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public byte? State { get; set; }

    public string? Url { get; set; }

    public DateTime CreatedTime { get; set; }

    public int SysFunId { get; set; }

    public string SysActCode { get; set; } = null!;

    public string SysActName { get; set; } = null!;

    public string SysFunName { get; set; } = null!;

    public bool IsFocus { get; set; }
}
