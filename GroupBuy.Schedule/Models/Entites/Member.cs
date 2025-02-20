using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 會員
/// </summary>
public partial class Member
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 真實姓名
    /// </summary>
    public string RealName { get; set; } = null!;

    /// <summary>
    /// 身分證字號(身分證號碼10碼;外來人口統一證號(居留證號)11碼)
    /// </summary>
    public string? IdNumber { get; set; }

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
    /// 手機號碼
    /// </summary>
    public string? Mobile { get; set; }

    /// <summary>
    /// 收貨人姓名
    /// </summary>
    public string? Receiver { get; set; }

    /// <summary>
    /// Facebook使用者ID (Facebook 的 ASID)
    /// </summary>
    public string? FBUsrId { get; set; }

    /// <summary>
    /// FB暱名(FB上所顯示的名稱)
    /// </summary>
    public string? FBName { get; set; }

    /// <summary>
    /// 經使用者授權存取(0-&gt;否,1-&gt;是)，若使用者登入時原授權改為未授權，狀態需更新
    /// </summary>
    public bool? FBAuthorize { get; set; }

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
    /// LINE暱名(Line上所顯示的名稱)
    /// </summary>
    public string? LineName { get; set; }

    /// <summary>
    /// LineToken
    /// </summary>
    public string? LineToken { get; set; }

    /// <summary>
    /// Line Notify Token
    /// </summary>
    public string? LineNotifyToken { get; set; }

    /// <summary>
    /// Line狀態訊息
    /// </summary>
    public string? LineStaMessage { get; set; }

    /// <summary>
    /// 會員即時頭像(依據最後登入使用的社群)
    /// </summary>
    public string? HeadImgUrl { get; set; }

    /// <summary>
    /// 國家代碼(From GiCountry)
    /// </summary>
    public string? GiCouCode { get; set; }

    /// <summary>
    /// 縣市區代碼(From GiCity)
    /// </summary>
    public string? GiCitCode { get; set; }

    /// <summary>
    /// 鄉鎮市區代碼(From GiPostCode)
    /// </summary>
    public string? GiPosCode { get; set; }

    /// <summary>
    /// 鄉鎮區域名
    /// </summary>
    public string? GiPosName { get; set; }

    /// <summary>
    /// 收貨地址
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

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
