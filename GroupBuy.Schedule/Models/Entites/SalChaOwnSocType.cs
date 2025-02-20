using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

public partial class SalChaOwnSocType
{
    /// <summary>
    /// 銷售渠道Id
    /// </summary>
    public int SalChaId { get; set; }

    /// <summary>
    /// 經營社群型態：FB :7, LINE:8，詳見 SocType
    /// </summary>
    public int OwnSocType { get; set; }
}
