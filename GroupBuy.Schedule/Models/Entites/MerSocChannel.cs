using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商家社群
/// </summary>
public partial class MerSocChannel
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 商家序號(from Merchant)
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 名稱(ex.LINE南屯、LINE北區…)
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 商家群組編號(from NumTable)
    /// </summary>
    public int? Num { get; set; }

    /// <summary>
    /// 社群類別(From SocType)
    /// </summary>
    public int SocTypeId { get; set; }

    /// <summary>
    /// 社群頻道ID
    /// </summary>
    public string SocChaId { get; set; } = null!;

    /// <summary>
    /// 社群公開與否(0-&gt;否,1-&gt;是)
    /// </summary>
    public bool? SocPrivacy { get; set; }

    /// <summary>
    /// Facebook 社團綁定的粉絲專頁 Id (只有在SocType=2時才可以有值)
    /// </summary>
    public string? FBGroIdBindPageId { get; set; }

    public string? FBGroIdAdmPageIds { get; set; }

    /// <summary>
    /// 經商家授權存取(0-&gt;否,1-&gt;是)，若商家登入時原授權改為未授權，狀態需更新
    /// </summary>
    public bool Authorized { get; set; }

    /// <summary>
    /// 與系統綁定(0-&gt;否,1-&gt;是)
    /// </summary>
    public bool Bind { get; set; }

    /// <summary>
    /// 是否為新版本粉專
    /// </summary>
    public bool IsNewPage { get; set; }

    /// <summary>
    /// 社群間父子關係 Ex: LINE社群底下多個聊天室 (父-&gt;子)(SocType:9 -&gt;10)，該欄位寫入MerSocChaId
    /// </summary>
    public int? ParentId { get; set; }

    public string? AccToken { get; set; }

    /// <summary>
    /// 社群賣場網址(由系統所產生的LINE賣場網址(非自行輸入))
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 狀態(0-&gt;停用,1-&gt;使用中,9-&gt;刪除)
    /// </summary>
    public string Status { get; set; } = null!;

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
