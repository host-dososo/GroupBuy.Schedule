using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class MerNotice
{
    public decimal Id { get; set; }

    /// <summary>
    /// 商家ID
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 作業功能ID
    /// </summary>
    public int? SysFunActId { get; set; }

    /// <summary>
    /// 應用層判斷SysFunActId執行對應程序之所需客製化參數
    /// </summary>
    public string? Data { get; set; }

    /// <summary>
    /// 通知標題
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 通知內容
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 狀態 null:none/0:Running/1:Success/2:Warning/3:Error
    /// </summary>
    public byte? State { get; set; }

    /// <summary>
    /// 通知導向連結
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// 是否已聚焦(閱讀,點擊)過
    /// </summary>
    public bool IsFocus { get; set; }

    /// <summary>
    /// 創建日期時間
    /// </summary>
    public DateTime CreatedTime { get; set; }
}
