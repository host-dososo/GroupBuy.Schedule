using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class MerUseLog
{
    /// <summary>
    /// 商家序號(Merchant)
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 年度
    /// </summary>
    public string Year { get; set; } = null!;

    /// <summary>
    /// 月份
    /// </summary>
    public string Month { get; set; } = null!;

    /// <summary>
    /// 第幾週
    /// </summary>
    public string Week { get; set; } = null!;

    /// <summary>
    /// 次數
    /// </summary>
    public int? Times { get; set; }

    public decimal? StayHours { get; set; }
}
