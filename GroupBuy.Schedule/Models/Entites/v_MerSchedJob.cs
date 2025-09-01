using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_MerSchedJob
{
    public int Id { get; set; }

    public string? JobId { get; set; }

    public string? HashKey { get; set; }

    public int MerchantId { get; set; }

    public byte? Type { get; set; }

    public int SysFunActId { get; set; }

    public int SysFunId { get; set; }

    public string SysActCode { get; set; } = null!;

    public string? JobContent { get; set; }

    public string? Result { get; set; }

    public string OwnSys { get; set; } = null!;

    public string FunName { get; set; } = null!;

    public bool? isOpen { get; set; }

    public string? PageURL { get; set; }

    public string? FunEnName { get; set; }

    public int? Father { get; set; }

    public string? FatherFunName { get; set; }

    public string ActName { get; set; } = null!;

    public string ActEnName { get; set; } = null!;

    public long? StateId { get; set; }

    public string? ScdStateName { get; set; }

    public string? TypeName { get; set; }

    public string? ScdStateChName { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatorName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? ExpireAt { get; set; }

    public string Arguments { get; set; } = null!;

    public string? Num { get; set; }
}
