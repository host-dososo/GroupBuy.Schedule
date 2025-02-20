using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商家取貨點使用者
/// </summary>
public partial class MerPicPoiUsr
{
    public int Id { get; set; }

    /// <summary>
    /// 取貨點管理者編號
    /// </summary>
    public int Num { get; set; }

    /// <summary>
    /// 取貨點id
    /// </summary>
    public int MerPicPoiId { get; set; }

    /// <summary>
    /// 真實全名
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 性別
    /// </summary>
    public bool? Sex { get; set; }

    /// <summary>
    /// 手機號碼
    /// </summary>
    public string Mobile { get; set; } = null!;

    /// <summary>
    /// 信箱
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// 生日
    /// </summary>
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// 身分證字號
    /// </summary>
    public string? IDNo { get; set; }

    /// <summary>
    /// 身分證發證日期
    /// </summary>
    public string? IDNoIssueDate { get; set; }

    /// <summary>
    /// 身分證發證類型 (0:初發,1:補發,2:換發)
    /// </summary>
    public byte? IDNoIssueType { get; set; }

    /// <summary>
    /// 身分證發證城市
    /// </summary>
    public string? IDNoIssueCityCode { get; set; }

    /// <summary>
    /// 通訊地址
    /// </summary>
    public string? ConAddress { get; set; }

    /// <summary>
    /// 戶籍地址
    /// </summary>
    public string? HoldAddress { get; set; }

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
    /// LINE頭照圖片
    /// </summary>
    public string? HeadImgUrl { get; set; }

    /// <summary>
    /// 是否已經加入取貨點 LINE 官方帳號
    /// </summary>
    public bool? IsJoinedOA { get; set; }

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
