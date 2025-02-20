using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 系統使用者
/// </summary>
public partial class SysUsr
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 帳號
    /// </summary>
    public string Account { get; set; } = null!;

    /// <summary>
    /// 密碼
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// LINE使用者ID
    /// </summary>
    public string? LineUsrId { get; set; }

    /// <summary>
    /// Line暱稱
    /// </summary>
    public string? LineName { get; set; }

    /// <summary>
    /// 是否為朋友
    /// </summary>
    public bool? LineFriFlag { get; set; }

    /// <summary>
    /// Friendship狀態變更註記
    /// </summary>
    public bool? LineFriChanged { get; set; }

    /// <summary>
    /// LINE頭照圖片
    /// </summary>
    public string? LinHeadPicUrl { get; set; }

    /// <summary>
    /// 中文姓名
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// 登入失敗次數統計
    /// </summary>
    public int AccessFailedCount { get; set; }

    /// <summary>
    /// 最後登入網路位址
    /// </summary>
    public string? LastLoginIP { get; set; }

    /// <summary>
    /// 最後登入日期時間
    /// </summary>
    public DateTime? LastLoginDateTime { get; set; }

    /// <summary>
    /// 登入次數
    /// </summary>
    public int LoginCount { get; set; }

    /// <summary>
    /// 商家使者帳號
    /// </summary>
    public int? MerUsrId { get; set; }

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
