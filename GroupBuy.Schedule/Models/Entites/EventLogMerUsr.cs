using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class EventLogMerUsr
{
    /// <summary>
    /// 商家序號(Merchant)
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 商家使用者(管理帳號)序號
    /// </summary>
    public int MerUsrId { get; set; }

    public string? MerUsrName { get; set; }

    /// <summary>
    /// 系統功能名稱
    /// </summary>
    public string FunName { get; set; } = null!;

    /// <summary>
    /// 頁面網址
    /// </summary>
    public string PageURL { get; set; } = null!;

    /// <summary>
    /// 造訪時間
    /// </summary>
    public DateTime VisitTime { get; set; }
}
