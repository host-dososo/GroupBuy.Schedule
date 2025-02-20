using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class v_SysFunAct
{
    public int Id { get; set; }

    public int SysFunId { get; set; }

    public string SysActCode { get; set; } = null!;

    public string OwnSys { get; set; } = null!;

    public string SysFunName { get; set; } = null!;

    public string SysActName { get; set; } = null!;

    public string SysActEnName { get; set; } = null!;
}
