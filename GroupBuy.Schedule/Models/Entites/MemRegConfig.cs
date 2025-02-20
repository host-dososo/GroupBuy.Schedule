using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 會員註冊設定檔
/// </summary>
public partial class MemRegConfig
{
    /// <summary>
    /// 唯一識別值
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 商家ID
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 會員註冊設定檔種類代碼
    /// </summary>
    public string ConfigTypeCode { get; set; } = null!;

    /// <summary>
    /// 註冊社群渠道
    /// </summary>
    public int? SocTypeId { get; set; }

    /// <summary>
    /// 名稱
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 設定值
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// 狀態 1:正常 0:停用 9:刪除
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// 創建日期時間
    /// </summary>
    public DateTime? CreatedTime { get; set; }

    /// <summary>
    /// 創建人員
    /// </summary>
    public int? Creator { get; set; }

    /// <summary>
    /// 更新日期時間
    /// </summary>
    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// 更新人員
    /// </summary>
    public int? Updater { get; set; }
}
