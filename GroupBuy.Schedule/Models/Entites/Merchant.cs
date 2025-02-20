using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 商家
/// </summary>
public partial class Merchant
{
    /// <summary>
    /// 序號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 商家類型(0:試用/1:正式/9:無限制)(from MerType)
    /// </summary>
    public string MerTypCode { get; set; } = null!;

    /// <summary>
    /// 商家方案(0:精簡/A:基本/B:進階/C:豪華)(from MerPlan)
    /// </summary>
    public string MerPlaCode { get; set; } = null!;

    /// <summary>
    /// 商家代碼(MerTypCode+Id左補0)
    /// </summary>
    public string? Code { get; set; }

    public string? HashId { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// 名稱
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 起始日
    /// </summary>
    public DateOnly? StartingDate { get; set; }

    /// <summary>
    /// 到期日期
    /// </summary>
    public DateOnly ExpiryDate { get; set; }

    /// <summary>
    /// 聯絡人姓名
    /// </summary>
    public string? ConName { get; set; }

    /// <summary>
    /// 聯絡人手機號碼
    /// </summary>
    public string? ConMobile { get; set; }

    /// <summary>
    /// 聯絡人電話
    /// </summary>
    public string? ConPhone { get; set; }

    /// <summary>
    /// 聯絡人E-Mail
    /// </summary>
    public string? ConMail { get; set; }

    /// <summary>
    /// 聯絡人國家代碼(from GiCountry)
    /// </summary>
    public string? ConGiCouCode { get; set; }

    /// <summary>
    /// 聯絡人縣市代碼(from GiCity)
    /// </summary>
    public string? ConGiCitCode { get; set; }

    /// <summary>
    /// 聯絡人郵遞區號(ZipCode)(from GiPosCode)
    /// </summary>
    public string? ConGiPosCode { get; set; }

    /// <summary>
    /// 聯絡人鄉鎮區名稱(from GiPosCode)
    /// </summary>
    public string? ConGiPosName { get; set; }

    /// <summary>
    /// 聯絡人地址
    /// </summary>
    public string? ConAddress { get; set; }

    /// <summary>
    /// 商家統一編號/身分證號
    /// </summary>
    public string? TaxId { get; set; }

    /// <summary>
    /// 加購小幫手人數
    /// </summary>
    public short AddPurUsrNum { get; set; }

    /// <summary>
    /// 可使用人數
    /// </summary>
    public short UseableUsrNum { get; set; }

    /// <summary>
    /// Fb社群(粉轉，社群)可用數量
    /// </summary>
    public short UseAbleFbSocChaNum { get; set; }

    /// <summary>
    /// 商家轉賬的賬戶
    /// </summary>
    public string? AccOfTrans { get; set; }

    /// <summary>
    /// 從何得知代碼
    /// </summary>
    public string? FinOutId { get; set; }

    /// <summary>
    /// 商家LINE網址
    /// </summary>
    public string? LineUrl { get; set; }

    /// <summary>
    /// 商家FB粉專網址
    /// </summary>
    public string? FbfUrl { get; set; }

    /// <summary>
    /// 商家FB社群網址
    /// </summary>
    public string? FbgUrl { get; set; }

    /// <summary>
    /// 商家IG網址
    /// </summary>
    public string? IgUrl { get; set; }

    public bool isValidated { get; set; }

    /// <summary>
    /// 經銷渠道商Id
    /// </summary>
    public int? RefSalChaId { get; set; }

    /// <summary>
    /// 推薦商家Id
    /// </summary>
    public int? RefMerId { get; set; }

    /// <summary>
    /// 所屬組織的方案序號
    /// </summary>
    public int? OrgPlanId { get; set; }

    /// <summary>
    /// 授權驗證序號
    /// </summary>
    public string? AuthedSno { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int Sort { get; set; }

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
