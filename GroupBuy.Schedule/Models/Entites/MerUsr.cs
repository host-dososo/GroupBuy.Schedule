using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商家使用者(管理帳號)
/// </summary>
public partial class MerUsr
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 商家序號(Merchant)
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 商家使用者角色(1-&gt;團主,2-&gt;小幫手)
    /// </summary>
    public int MerRolId { get; set; }

    /// <summary>
    /// 是否為最高管理者
    /// </summary>
    public bool IsMaster { get; set; }

    /// <summary>
    /// 帳號
    /// </summary>
    public string? Account { get; set; }

    /// <summary>
    /// 密碼
    /// </summary>
    public string? Password { get; set; }

    /// <summary>
    /// 中文姓名
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 性別(1-&gt;男性,2-&gt;女性,0-&gt;其他)
    /// </summary>
    public string? Gender { get; set; }

    /// <summary>
    /// 生日
    /// </summary>
    public DateOnly? Birthday { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// 聯絡電話
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// 手機號碼(小幫手可以空值,管理者不可空值)
    /// </summary>
    public string? Mobile { get; set; }

    /// <summary>
    /// 記錄錯誤次數(三次后啓動驗證碼)
    /// </summary>
    public int ValFaiCount { get; set; }

    /// <summary>
    /// 登入失敗次數統計
    /// </summary>
    public int AccFaiCount { get; set; }

    /// <summary>
    /// 最後登入網路位址
    /// </summary>
    public string? LasLogIP { get; set; }

    /// <summary>
    /// 最後登入日期時間
    /// </summary>
    public DateTime? LasLogTime { get; set; }

    /// <summary>
    /// 登入次數
    /// </summary>
    public int LogCount { get; set; }

    /// <summary>
    /// Facebook使用者ID (Facebook 的 ASID)
    /// </summary>
    public string? FBUsrId { get; set; }

    /// <summary>
    /// Facebook姓名
    /// </summary>
    public string? FBName { get; set; }

    /// <summary>
    /// Facebook Login Connect with Messenger 取得的 Login Id
    /// </summary>
    public string? FBRecipientLoginId { get; set; }

    /// <summary>
    /// Facebook 長時效 token
    /// </summary>
    public string? FBLongLivedToken { get; set; }

    /// <summary>
    /// Facebook 的 PSID (根據FBRecipientLoginId發送初始message給user，回覆後取得該PSID)
    /// </summary>
    public string? FBPSID { get; set; }

    /// <summary>
    /// LINE使用者ID
    /// </summary>
    public string? LineUsrId { get; set; }

    /// <summary>
    /// Line暱稱
    /// </summary>
    public string? LineName { get; set; }

    /// <summary>
    /// Line Access Token
    /// </summary>
    public string? LineToken { get; set; }

    /// <summary>
    /// Line Notify Token
    /// </summary>
    public string? LineNotifyToken { get; set; }

    /// <summary>
    /// 是否為朋友
    /// </summary>
    public bool? LineFriFlag { get; set; }

    /// <summary>
    /// Friendship狀態變更註記
    /// </summary>
    public bool? LineFriChanged { get; set; }

    /// <summary>
    /// Line狀態訊息
    /// </summary>
    public string? LineStaMessage { get; set; }

    /// <summary>
    /// LINE頭照圖片
    /// </summary>
    public string? HeadImgUrl { get; set; }

    /// <summary>
    /// 是否啓用
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 狀態
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
