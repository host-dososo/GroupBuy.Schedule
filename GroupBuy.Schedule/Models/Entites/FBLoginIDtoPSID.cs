using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class FBLoginIDtoPSID
{
    /// <summary>
    /// login ID by hash_hmac
    /// </summary>
    public string login_ID { get; set; } = null!;

    /// <summary>
    /// Application scoped ID
    /// </summary>
    public string? ASID { get; set; }

    /// <summary>
    /// Recipient ID
    /// </summary>
    public string? recipient_ID { get; set; }

    /// <summary>
    /// Page scoped ID
    /// </summary>
    public string? PSID { get; set; }

    /// <summary>
    /// 授權 Messenger 通知按鈕旁邊授權碼
    /// </summary>
    public string? AuthHashCode { get; set; }

    public string? UID { get; set; }

    /// <summary>
    /// FB 應用程式 ID
    /// </summary>
    public string AppId { get; set; } = null!;

    /// <summary>
    /// 前台or後台  1:後台 0:前台
    /// </summary>
    public byte OwnSys { get; set; }

    public string? UserName { get; set; }

    public DateTime? CreatedTime { get; set; }
}
