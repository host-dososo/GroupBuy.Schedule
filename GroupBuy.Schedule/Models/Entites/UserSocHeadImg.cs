using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 會員社群頭貼 - LINE 群組綁定需要頭貼連結作為綁定依據，未來也可以前端抓此表顯示頭貼
/// </summary>
public partial class UserSocHeadImg
{
    /// <summary>
    /// 使用者ID (參照OwnSys 決定商家or會員)
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// ref: dbo.SocType
    /// </summary>
    public byte SocTypeId { get; set; }

    /// <summary>
    /// 0: 會員/ 1:商家
    /// </summary>
    public byte OwnSys { get; set; }

    /// <summary>
    /// 頭貼連結
    /// </summary>
    public string HeadImgUrl { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 變更時間
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
