using System;
using System.Collections.Generic;

namespace GroupBuy.Schedule.Models.Entites;

/// <summary>
/// 優惠活動贈送好禮商品規格
/// </summary>
public partial class PromoRewGooSpec
{
    public int PromoRewardId { get; set; }

    public long GooSpeId { get; set; }
}
