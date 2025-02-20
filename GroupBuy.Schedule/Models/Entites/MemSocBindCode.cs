using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class MemSocBindCode
{
    public int MemberId { get; set; }

    /// <summary>
    /// 綁至哪個社群 (join to SocType table)
    /// </summary>
    public int BindToSocTypeId { get; set; }

    /// <summary>
    /// 會員執行綁定時當下登入之商家
    /// </summary>
    public int? MerchantId { get; set; }

    /// <summary>
    /// 申請綁定時的 Mobile
    /// </summary>
    public string? Mobile { get; set; }

    /// <summary>
    /// 申請綁定時的 Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// 判定為相同使用者所依據屬性，第一位為 Email，第二位為 Mobile (Ex: 只相同 Email =&gt; 10,只相同 Mobile =&gt; 01,  Email和Mobile皆相同 =&gt; 11)
    /// </summary>
    public string? SameItem { get; set; }

    /// <summary>
    /// 驗證碼
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 若是從 Messenger 對話綁定，則紀錄對話對方 PSID
    /// </summary>
    public string? FBPSID { get; set; }

    /// <summary>
    /// 發送時間
    /// </summary>
    public DateTime SendTime { get; set; }

    public bool SendSuccess { get; set; }

    public bool BindSuccess { get; set; }

    /// <summary>
    /// 創建日期時間
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 創建人員
    /// </summary>
    public int Creator { get; set; }

    /// <summary>
    /// 更新日期時間
    /// </summary>
    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// 更新人員
    /// </summary>
    public int? Updater { get; set; }
}
