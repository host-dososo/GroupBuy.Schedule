using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商家會員收貨資訊
/// </summary>
public partial class MerMemShiInfo
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 商家序號
    /// </summary>
    public int MerchantId { get; set; }

    /// <summary>
    /// 會員序號
    /// </summary>
    public int MemberId { get; set; }

    /// <summary>
    /// 預設地址(0:否/1:是)
    /// </summary>
    public bool IsMaster { get; set; }

    /// <summary>
    /// 收貨人名稱
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 收貨人手機號碼
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// 收貨人國家代碼
    /// </summary>
    public string GiCouCode { get; set; } = null!;

    /// <summary>
    /// 收貨人縣市區代碼(From GiCity)
    /// </summary>
    public string GiCitCode { get; set; } = null!;

    /// <summary>
    /// 收貨人鄉鎮市區代碼(From GiPostCode)
    /// </summary>
    public string GiPosCode { get; set; } = null!;

    /// <summary>
    /// 鄉鎮區域名
    /// </summary>
    public string GiPosName { get; set; } = null!;

    /// <summary>
    /// 收貨人地址
    /// </summary>
    public string Address { get; set; } = null!;

    /// <summary>
    /// 創建時間
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 創建者
    /// </summary>
    public int Creator { get; set; }

    /// <summary>
    /// 編輯時間
    /// </summary>
    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// 編輯者
    /// </summary>
    public int? Updater { get; set; }
}
